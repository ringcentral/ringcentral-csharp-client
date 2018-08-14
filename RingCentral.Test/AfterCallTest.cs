using System;
using System.Threading;
using Xunit;
using System.Linq;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class AfterCallTest : IDisposable
    {
        private RestClient rc;
        public AfterCallTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void AfterCall()
        {
            RestClient.AfterCall = (httpCall) =>
            {
                var rateLimitRemaining = httpCall.Response.Headers.GetValues("X-Rate-Limit-Remaining").FirstOrDefault();
                Console.WriteLine(rateLimitRemaining);
            };
            const string phoneNumber = "+15889546648";
            var addressBook = rc.Restapi().Account().Extension().AddressBook();

            var listt = await addressBook.Contact().List(new { phoneNumber = phoneNumber });
            RestClient.AfterCall = null;
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}