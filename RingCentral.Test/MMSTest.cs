using System;
using System.Threading;
using System.IO;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class MMSTest : IDisposable
    {
        private RestClient rc;
        public MMSTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void SendMMS()
        {
            var extension = rc.Restapi().Account().Extension();
            var attachment1 = new Attachment { fileName = "test.png", contentType = "image/png", bytes = System.IO.File.ReadAllBytes("test.png") };
            var attachments = new Attachment[] { attachment1 };
            var response = await extension.Sms().Post(new
            {
                to = new CallerInfo[] { new CallerInfo { phoneNumber = Config.Instance.receiver } },
                from = new CallerInfo { phoneNumber = Config.Instance.username },
                text = "Hello world again"
            }, attachments);
            Assert.NotNull(response);
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
