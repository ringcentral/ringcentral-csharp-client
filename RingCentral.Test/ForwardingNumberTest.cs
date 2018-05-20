using System;
using System.Threading;
using System.IO;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class ForwardingNumberTest : IDisposable
    {
        private RestClient rc;
        public ForwardingNumberTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void GetForwardingNumberList()
        {
            var extension = rc.Restapi().Account().Extension();
            var response = await rc.Get(extension.ForwardingNumber().Endpoint(false));
            var body = await response.Content.ReadAsStringAsync();
            Assert.NotNull(response);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
