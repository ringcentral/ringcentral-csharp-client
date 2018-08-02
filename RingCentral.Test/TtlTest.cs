using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class TtlTest : IDisposable
    {
        private RestClient rc;
        public TtlTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void TestRefresh()
        {
            Assert.Equal(3600, rc.access_token_ttl);
            await rc.Refresh();
            Assert.Equal(3600, rc.access_token_ttl);
            rc.access_token_ttl = 1800;
            await rc.Refresh();
            Assert.Equal(1800, rc.access_token_ttl);
        }

        [Fact]
        public async void TestAuth()
        {
            rc.access_token_ttl = 1800;
            var token = await rc.Authorize(Config.Instance.username, "", Config.Instance.password);
            Assert.Equal(1800, rc.access_token_ttl);
            Assert.True(token.expires_in > 1700 && token.expires_in < 1900);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
