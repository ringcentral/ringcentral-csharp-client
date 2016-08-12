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
        public void Refresh()
        {
            var oldToken = rc.token.access_token;
            rc.Refresh();
            Assert.NotNull(rc.token);
            Assert.NotEqual(oldToken, rc.token.access_token);

            var temp = new RestClient("", "");
            temp.Refresh(); // refresh null token
            Assert.Null(temp.token);

            temp.Revoke(); // revoke null token
            Assert.Null(temp.token);
        }

        [Fact]
        public void AuthorizeUri()
        {
            var redirectUri = "http://localhost:3000/callback";
            var uri = rc.AuthorizeUri(redirectUri, "myState");
            Assert.NotNull(uri);
            Assert.Equal("myState", Url.ParseQueryParams(uri).First(qp => qp.Name == "state").Value.ToString());
            try
            {
                rc.Authorize("fakeCode", redirectUri);
            }
            catch (AggregateException ae)
            {
                ae.Handle((x) =>
                {
                    if (x is FlurlHttpException) // This we know how to handle.
                    {
                        var fhe = x as FlurlHttpException;
                        Assert.Equal(fhe.Call.Response.StatusCode, HttpStatusCode.Unauthorized);
                        return true;
                    }
                    return false;
                });
            }
        }

        public void Dispose()
        {
            Thread.Sleep(3000);
        }
    }
}
