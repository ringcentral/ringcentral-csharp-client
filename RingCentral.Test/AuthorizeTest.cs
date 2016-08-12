using Flurl;
using System;
using System.Linq;
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

            var temp = new RestClient("", "");
            temp.Refresh(); // refresh null token
            Assert.Null(temp.token);
        }

        [Fact]
        public void AuthorizeUri()
        {
            var uri = rc.AuthorizeUri("http://localhost:3000/callback", "myState");
            Assert.NotNull(uri);
            Assert.Equal("myState", Url.ParseQueryParams(uri).First(qp => qp.Name == "state").Value.ToString());
        }

        public void Dispose()
        {
            Thread.Sleep(3000);
        }
    }
}
