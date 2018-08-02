using System;
using System.Threading;
using Flurl.Http;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class WebHookTest : IDisposable
    {
        private RestClient rc;
        public WebHookTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void SetupWebHook()
        {
            try
            {
                var r = await rc.Restapi().Subscription().Post(new CreateSubscriptionRequest
                {
                    eventFilters = new string[] { "/restapi/v1.0/account/~/extension/~/message-store" },
                    deliveryMode = new NotificationDeliveryModeRequest
                    {
                        transportType = "WebHook",
                        address = "http://www.example.com/webhook"
                    }
                });
            } catch(FlurlHttpException fhe) {
                string errorMessage = await fhe.GetResponseStringAsync();
                Console.WriteLine(errorMessage);
                Assert.Equal("{\"errorCode\":\"SUB-521\",\"message\":\"WebHook is not reachable\",\"errors\":[{\"errorCode\":\"SUB-521\",\"message\":\"WebHook is not reachable\"}]}", errorMessage);
            }
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
