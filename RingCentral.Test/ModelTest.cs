using Xunit;

namespace RingCentral.Test
{
    public class ModelTest
    {
        [Fact]
        public void MockTest()
        {
            var rc = new RestClient("", "");
            Assert.NotNull(rc);
            var restapi = rc.Restapi();
            Assert.Equal(rc.server + "/restapi/v1.0", restapi.Url());
            Assert.Equal(rc.server + "/restapi", restapi.Url(false));
            Assert.Equal("/restapi/v1.0", restapi.Endpoint());
            Assert.Equal("/restapi", restapi.Endpoint(false));

            var callLog = restapi.Account().Extension().CallLog("123456");
            Assert.Equal("/restapi/v1.0/account/~/extension/~/call-log/123456", callLog.Endpoint());
            Assert.Equal("/restapi/v1.0/account/~/extension/~/call-log", callLog.Endpoint(false));
            Assert.Equal(rc.server + "/restapi/v1.0/account/~/extension/~/call-log/123456", callLog.Url());
            Assert.Equal(rc.server + "/restapi/v1.0/account/~/extension/~/call-log", callLog.Url(false));

            Assert.Equal("/restapi/v1.0/dictionary/country", restapi.Dictionary().Country().Endpoint());
        }
    }
}