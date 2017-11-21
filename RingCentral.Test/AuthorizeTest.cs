using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
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
                Assert.Equal(fhe.Call.Response.StatusCode, HttpStatusCode.BadRequest);
            }
        }


        [Fact]
        public async void TestRefreshWithTokenOnly()
        {
            // 假设 data 是从文件读出来的
            var data = JsonConvert.SerializeObject(rc.token);

            // 假设当前的 token 是 null， 也就是没登录
            rc.token = null;

            // 反序列得出 token
            var token = JsonConvert.DeserializeObject<TokenInfo>(data);

            // 直接根据token参数进行refresh
            await rc.Refresh(token.refresh_token);

            // 成功从服务器端获取了 token
            Assert.NotNull(rc.token);

            // 验证 access_token 不为空
            Assert.NotNull(rc.token.access_token);
        }

        [Fact]
        public async void TestRefreshWithSavedToken()
        {
            // 假设 data 是从文件读出来的
            var data = JsonConvert.SerializeObject(rc.token);

            // 假设当前的 token 是 null， 也就是没登录
            rc.token = null;

            // 反序列得出 token
            var token = JsonConvert.DeserializeObject<TokenInfo>(data);
            rc.token = token;

            // refresh
            await rc.Refresh();

            // 成功从服务器端获取了 token
            Assert.NotNull(rc.token);

            // 验证 access_token 不为空
            Assert.NotNull(rc.token.access_token);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
