using Xunit;

namespace RingCentral.Test
{
    public class HttpTest
    {
        [Fact]
        public void GetTest()
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
            rc.Authorize(Config.Instance.username, Config.Instance.extension, Config.Instance.password);

            Assert.NotNull(rc.token.access_token);
        }
    }
}