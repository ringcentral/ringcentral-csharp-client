using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class SubscripotionTest : IDisposable
    {
        private RestClient rc;
        public SubscripotionTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        private async void SendSMS()
        {
            var requestBody = new
            {
                text = "hello world",
                from = new { phoneNumber = Config.Instance.username },
                to = new object[] { new { phoneNumber = Config.Instance.receiver } }
            };
            var temp = await rc.Restapi().Account().Extension().Sms().Post(requestBody);
        }

        [Fact]
        public async void MessageNotifications()
        {
            var subscription = rc.Restapi().Subscription().New();
            subscription.EventFilters.Add("/restapi/v1.0/account/~/extension/~/message-store");
            subscription.EventFilters.Add("/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true");
            var presenceCount = 0;
            subscription.PresenceEvent += (sender, args) => {
                presenceCount += 1;
                Console.WriteLine(args.Message);
            };
            var messageCount = 0;
            var messageNotificationCount = 0;
            subscription.NotificationEvent += (sender, args) => {
                messageCount += 1;
                var notification = args.notification;
                switch (notification.type)
                {
                    case NotificationType.Message:
                        var messageNotification = notification.Downcast<MessageNotification>();
                        messageNotificationCount += 1;
                        break;
                    case NotificationType.DetailedPresence:
                        var detailedPresenceNotification = notification.Downcast<DetailedPresenceNotification>();
                        break;
                    default:
                        break;
                }
            };
            var statusCount = 0;
            subscription.StatusEvent += (sender, args) => {
                statusCount += 1;
                Console.WriteLine(args.Message);
            };
            await subscription.Register();
            SendSMS();
            Thread.Sleep(10000);
            await subscription.Remove();
            Assert.Equal(0, presenceCount);
            Assert.True(messageCount >= 1);
            Assert.True(messageNotificationCount >= 1);
            Assert.Equal(1, statusCount);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
