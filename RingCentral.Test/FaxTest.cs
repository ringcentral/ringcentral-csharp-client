using System.IO;
using System.Text;
using Xunit;

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
            var attachment1 = new Attachment { fileName = "test.txt", contentType = "text/plain", bytes = Encoding.UTF8.GetBytes("hello world") };
            var attachment2 = new Attachment { fileName = "test.pdf", contentType = "application/pdf", bytes = File.ReadAllBytes("test.pdf") };
            var attachments = new Attachment[] { attachment1, attachment2 };
            var response = extension.Fax().Post(new Fax.PostRequest
            {
                to = new Fax.PostRequest.To[] { new Fax.PostRequest.To { phoneNumber = Config.Instance.receiver } }
            }, attachments).Result;
            Assert.NotNull(response);
            Assert.Equal("High", response.faxResolution);
        }
    }
}
