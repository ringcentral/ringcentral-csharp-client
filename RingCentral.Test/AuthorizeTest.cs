using Flurl;
using Flurl.Http;
using System;
using System.Linq;
using System.Net;
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
        public async void Refresh()
        {
            var oldToken = rc.token.access_token;
            await rc.Refresh();
            Assert.NotNull(rc.token);
            Assert.NotEqual(oldToken, rc.token.access_token);

            var temp = new RestClient("", "");
            await temp.Refresh(); // refresh null token
            Assert.Null(temp.token);

            await temp.Revoke(); // revoke null token
            Assert.Null(temp.token);
        }

        [Fact]
        public async void AuthorizeUri()
        {
            var redirectUri = "http://localhost:3000/callback";
            var uri = rc.AuthorizeUri(redirectUri, "myState");
            Assert.NotNull(uri);
            Assert.Equal("myState", Url.ParseQueryParams(uri).First(qp => qp.Name == "state").Value.ToString());
            try
            {
                await rc.Authorize("fakeCode", redirectUri);
            }
            catch (FlurlHttpException fhe)
            {
                Assert.Equal(fhe.Call.Response.StatusCode, HttpStatusCode.Unauthorized);
            }
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
