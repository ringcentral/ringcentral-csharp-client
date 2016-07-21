using Xunit;

namespace RingCentral.Test
{
    public class RestClientTest
    {
        [Fact]
        public void MockTest()
        {
            var rc = new RestClient("", "", "");
            var restapi = rc.Restapi();
            Assert.NotNull(restapi);
        }
    }
}