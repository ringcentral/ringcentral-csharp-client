using System;
using System.IO;
using System.Linq;
using System.Threading;
using Xunit;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class BinaryTest : IDisposable
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
        public void MessageContent()
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

        [Fact]
        public void RecordingContent()
        {
            var account = rc.Restapi().Account();

            // List call Logs
            var queryParams = new CallLog.ListQueryParams
            {
                type = "Voice",
                view = "Detailed",
                dateFrom = DateTime.UtcNow.AddDays(-100).ToString("o"),
                withRecording = true,
                perPage = 10,
            };
            var callLogs = account.CallLog().List(queryParams).Result;
            Assert.Equal(10, callLogs.records.Length);

            // download a call recording
            var callLog = callLogs.records[0];
            var bytes = account.Recording(callLog.recording.id).Content().Get().Result;
            Assert.NotNull(bytes);
            Assert.True(bytes.Length > 0);
            File.WriteAllBytes("test.wav", bytes);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
