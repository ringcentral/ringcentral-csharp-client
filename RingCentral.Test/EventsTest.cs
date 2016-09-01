using System;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class EventsTest : IDisposable
    {
        private RestClient rc;
        public EventsTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void TokenEvent()
        {
            var temp = 0;
            rc.TokenRefreshed += (object sender, TokenEventArgs e) =>
            {
                temp += 1;
            };
            await rc.Refresh();
            Thread.Sleep(5000);
            await rc.Refresh();
            Thread.Sleep(5000);
            await rc.Refresh();
            Assert.Equal(3, temp);
        }
        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
