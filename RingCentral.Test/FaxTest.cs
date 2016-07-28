using Xunit;
using System;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class FaxTest
    {
        private RestClient rc;
        public FaxTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void SendFax()
        {
            var extension = rc.Restapi().Account().Extension();
            var response = extension.Fax().Post(new Fax.PostRequest
            {
                faxResolution = "High",
                to = new Fax.PostRequest.To[] { new Fax.PostRequest.To { phoneNumber = Config.Instance.receiver } }
            }, null).Result;
            Assert.NotNull(response);
        }
    }
}
