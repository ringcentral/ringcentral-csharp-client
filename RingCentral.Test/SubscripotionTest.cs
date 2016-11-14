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
            var connectCount = 0;
            subscription.ConnectEvent += (sender, args) => {
                connectCount += 1;
                Console.WriteLine(args.Message);
            };
            var messageCount = 0;
            var messageNotificationCount = 0;
            subscription.NotificationEvent += (sender, args) => {
                messageCount += 1;
                var notification = args.notification;
                Console.WriteLine(notification.@event);
                if (notification.type == NotificationType.Message)
                {
                    var messageNotification = notification.Downcast<MessageNotification>();
                    messageNotificationCount += 1;
                }
                else if (notification.type == NotificationType.DetailedPresence)
                {
                    var detailedPresenceNotification = notification.Downcast<DetailedPresenceNotification>();
                }
            };
            var errorCount = 0;
            subscription.ErrorEvent += (sender, args) => {
                errorCount += 1;
                Console.WriteLine(args.Message);
            };
            await subscription.Register();
            SendSMS();
            Thread.Sleep(15000);
            SendSMS();
            Thread.Sleep(15000);
            await subscription.Remove();
            Assert.Equal(1, connectCount);
            Assert.True(messageCount >= 2);
            Assert.True(messageNotificationCount >= 2);
            Assert.Equal(0, errorCount);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
