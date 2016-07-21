using System;
using Xunit;

namespace RingCentral.Test
{
    public class RestClientFixture : IDisposable
    {
        public RestClient rc { get; private set; }

        public RestClientFixture()
        {
            if (!string.IsNullOrWhiteSpace(Config.Instance.server))
            {
                rc = new RestClient(Config.Instance.appKey, Config.Instance.appSecret, Config.Instance.server);
            }
            else
            {
                rc = new RestClient(Config.Instance.appKey, Config.Instance.appSecret, Config.Instance.production.Value);
            }
            rc.Authorize(Config.Instance.username, Config.Instance.extension, Config.Instance.password);
        }

        public void Dispose()
        {
            rc.Revoke();
        }
    }

    [CollectionDefinition("RestClient collection")]
    public class RestClientCollection : ICollectionFixture<RestClientFixture>
    {
    }
}