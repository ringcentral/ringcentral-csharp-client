using System;
using System.Text.RegularExpressions;
using System.Threading;
using Xunit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            var presenceCount = 0;
            subscription.PresenceEvent += (sender, args) => {
                presenceCount += 1;
                Console.WriteLine(args.Message);
            };
            var messageCount = 0;
            var messageNotificationCount = 0;
            subscription.NotificationEvent += (sender, args) => {
                messageCount += 1;
                var message = args.message;
                Console.WriteLine(message);
                dynamic jObject = JObject.Parse(message);
                var eventString = (string)jObject.@event;
                if(new Regex("/account/\\d+/extension/\\d+/message-store").Match(eventString).Success) {
                    messageNotificationCount += 1;
                    var bodyString = JsonConvert.SerializeObject(jObject.body);
                    var messageEvent = JsonConvert.DeserializeObject<MessageEvent>(bodyString);
                    Console.WriteLine(messageEvent.extensionId);
                    Console.WriteLine(messageEvent.changes[0].type);
                }
            };
            var statusCount = 0;
            subscription.StatusEvent += (sender, args) => {
                statusCount += 1;
                Console.WriteLine(args.Message);
            };
            await subscription.Register();
            SendSMS();
            Thread.Sleep(15000);
            await subscription.Remove();
            Assert.Equal(0, presenceCount);
            Assert.True(messageCount >= 1);
            Assert.True(messageNotificationCount >= 1);
            Assert.True(statusCount >= 1);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
