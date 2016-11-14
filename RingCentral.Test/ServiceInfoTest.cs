using System;
using System.Linq;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class ServiceInfoTest : IDisposable
    {
        private RestClient rc;
        public ServiceInfoTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void ServiceInfo()
        {
            // account service-info
            var account = rc.Restapi().Account();
            var accountServiceInfo = await account.ServiceInfo().Get();
            var faxReceiving = accountServiceInfo.serviceFeatures.First(item => item.featureName == "FaxReceiving").enabled;
            Assert.True(faxReceiving);

            // meeting service-info
            //var meetingServiceInfo = await account.Extension().MeetingServiceInfo().Get();
            //Assert.NotNull(meetingServiceInfo);
            // todo: meeting api is internal, so I always get 403
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
