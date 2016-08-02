using System.IO;
using System.Linq;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class BinaryTest
    {
        private RestClient rc;
        private byte[] bytes;
        public BinaryTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
            bytes = File.ReadAllBytes("test.png");
        }

        [Fact]
        public void ProfileImage()
        {
            var extension = rc.Restapi().Account().Extension();

            var temp = extension.ProfileImage().Post(bytes, "test.png").Result;
            Assert.NotNull(temp);

            var bytes3 = extension.ProfileImage().Get().Result;
            Assert.NotNull(bytes3);
            Assert.Equal(bytes, bytes3);

            var bytes4 = extension.ProfileImage("90x90").Get().Result;
            Assert.NotNull(bytes4);

            temp = extension.ProfileImage().Put(bytes, "test.png").Result;
            Assert.NotNull(temp);

            var bytes5 = extension.ProfileImage().Get().Result;
            Assert.NotNull(bytes5);
            Assert.Equal(bytes, bytes5);

            var bytes6 = extension.ProfileImage("90x90").Get().Result;
            Assert.NotNull(bytes6);
        }

        [Fact]
        public void Content()
        {
            var extension = rc.Restapi().Account().Extension();

            var messages = extension.MessageStore().List().Result.records;

            // sms
            var message = messages.Where(m => m.type == "SMS" && m.attachments != null && m.attachments.Length > 0).First();
            var bytes = extension.MessageStore(message.id).Content(message.attachments[0].id).Get().Result;
            var content = System.Text.Encoding.UTF8.GetString(bytes);
            Assert.NotNull(content);
            Assert.True(content.Length > 0);

            // fax
            message = messages.Where(m => m.type == "Fax" && m.attachments != null && m.attachments.Length > 0).First();
            bytes = extension.MessageStore(message.id).Content(message.attachments[0].id).Get().Result;
            Assert.NotNull(bytes);
            Assert.True(bytes.Length > 0);
            File.WriteAllBytes("test.pdf", bytes);
        }
    }
}
