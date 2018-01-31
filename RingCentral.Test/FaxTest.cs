using System;
using System.Text;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class FaxTest : IDisposable
    {
        private RestClient rc;
        public FaxTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void SendFax()
        {
            var extension = rc.Restapi().Account().Extension();
            var attachment1 = new Attachment { fileName = "test.txt", contentType = "text/plain", bytes = Encoding.UTF8.GetBytes("hello world") };
            var attachment2 = new Attachment { fileName = "test.pdf", contentType = "application/pdf", bytes = System.IO.File.ReadAllBytes("test.pdf") };
            var attachments = new Attachment[] { attachment1, attachment2 };
            var response = await extension.Fax().Post(new
            {
                to = new CallerInfo[] { new CallerInfo { phoneNumber = Config.Instance.receiver } }
            }, attachments);
            Assert.NotNull(response);
            Assert.Equal("High", response.faxResolution);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
