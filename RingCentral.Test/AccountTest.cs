using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class AccountTest : IDisposable
    {
        private RestClient rc;
        public AccountTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void GetAccount()
        {
            var account = await rc.Restapi().Account().Get();
            Assert.NotNull(account);
            Assert.NotNull(account.serviceInfo);
        }
        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
