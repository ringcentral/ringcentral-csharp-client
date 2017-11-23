using Flurl.Http;
using System;
using System.IO;
using System.Text;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class MmsTest : IDisposable
    {
        private RestClient rc;
        public MmsTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void SendMms()
        {
            var extension = rc.Restapi().Account().Extension();
            var attachment = new Attachment { fileName = "test.png", contentType = "image/png", bytes = File.ReadAllBytes("test.png") };
            var attachments = new Attachment[] { attachment };
            var response = await extension.Mms().Post(new MmsPath.PostParameters
            {
                from = new CallerInfo { phoneNumber = Config.Instance.username },
                to = new CallerInfo[] { new CallerInfo { phoneNumber = Config.Instance.receiver } },
                text = "Hello world"
            }, attachments);
            Assert.NotNull(response);
            Assert.Equal(response.attachments.Length, 2); // one for "Hello world", the other for image.
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
