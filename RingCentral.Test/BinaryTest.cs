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
        public async void ProfileImage()
        {
            var extension = rc.Restapi().Account().Extension();

            var temp = await extension.ProfileImage().Post(bytes, "test.png");
            Assert.NotNull(temp);

            var bytes3 = await extension.ProfileImage().Get();
            Assert.NotNull(bytes3);
            Assert.Equal(bytes, bytes3);

            var bytes4 = await extension.ProfileImage("90x90").Get();
            Assert.NotNull(bytes4);

            temp = await extension.ProfileImage().Put(bytes, "test.png");
            Assert.NotNull(temp);

            var bytes5 = await extension.ProfileImage().Get();
            Assert.NotNull(bytes5);
            Assert.Equal(bytes, bytes5);

            var bytes6 = await extension.ProfileImage("90x90").Get();
            Assert.NotNull(bytes6);
        }

        [Fact]
        public async void MessageContent()
        {
            var extension = rc.Restapi().Account().Extension();

            var response = await extension.MessageStore().List();
            var messages = response.records;

            // sms
            var message = messages.Where(m => m.type == "SMS" && m.attachments != null && m.attachments.Length > 0).First();
            var bytes = await extension.MessageStore(message.id).Content(message.attachments[0].id).Get();
            var content = System.Text.Encoding.UTF8.GetString(bytes);
            Assert.NotNull(content);
            Assert.True(content.Length > 0);

            // fax
            message = messages.Where(m => m.type == "Fax" && m.attachments != null && m.attachments.Length > 0).First();
            bytes = await extension.MessageStore(message.id).Content(message.attachments[0].id).Get();
            Assert.NotNull(bytes);
            Assert.True(bytes.Length > 0);
            File.WriteAllBytes("test.pdf", bytes);
        }

        [Fact]
        public async void RecordingContent()
        {
            var account = rc.Restapi().Account();

            // List call Logs
            var queryParams = new CallLog.ListQueryParams
            {
                type = "Voice",
                view = "Detailed",
                dateFrom = DateTime.UtcNow.AddDays(-365).ToString("o"),
                withRecording = true,
                perPage = 10,
            };
            var callLogs = await account.CallLog().List(queryParams);
            Assert.True(callLogs.records.Length > 0);

            // download a call recording
            var callLog = callLogs.records[0];
            var bytes = await account.Recording(callLog.recording.id).Content().Get();
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
