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
            var count = 0;
            EventHandler<HttpCallEventArgs> eventHandler = (object sender, HttpCallEventArgs args) =>
            {
                var rateLimitRemaining = args.HttpCall.Response.Headers.GetValues("X-Rate-Limit-Remaining").FirstOrDefault();
                Console.WriteLine(rateLimitRemaining);
                count += 1;
            };
            rc.AfterHttpCall += eventHandler;

            const string phoneNumber = "+15889546648";
            var addressBook = rc.Restapi().Account().Extension().AddressBook();
            var listt = await addressBook.Contact().List(new { phoneNumber = phoneNumber });

            rc.AfterHttpCall -= eventHandler;
            Assert.Equal(1, count);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}