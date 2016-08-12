using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class AuthorizeTest : IDisposable
    {
        private RestClient rc;
        public AuthorizeTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void Refresh()
        {
            var oldToken = rc.token.access_token;
            rc.Refresh();
            Assert.NotNull(rc.token);
            Assert.NotEqual(oldToken, rc.token.access_token);
        }

        public void Dispose()
        {
            Thread.Sleep(3000);
        }
    }
}
