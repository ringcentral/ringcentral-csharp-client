using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    public class HttpTest : IDisposable
    {
        [Fact]
        public async void GetTest()
        {
            RestClient rc = null;
            if (!string.IsNullOrWhiteSpace(Config.Instance.server))
            {
                rc = new RestClient(Config.Instance.appKey, Config.Instance.appSecret, Config.Instance.server);
            }
            else
            {
                rc = new RestClient(Config.Instance.appKey, Config.Instance.appSecret, Config.Instance.production.Value);
            }
            await rc.Authorize(Config.Instance.username, Config.Instance.extension, Config.Instance.password);

            Assert.NotNull(rc.token.access_token);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}