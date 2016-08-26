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
        public void GetAccount()
        {
            var account = rc.Restapi().Account().Get().Result;
            Assert.NotNull(account);
            Assert.NotNull(account.serviceInfo);
        }
        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
