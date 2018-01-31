using System;
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
            bytes = System.IO.File.ReadAllBytes("test.png");
        }

        [Fact]
        public async void ProfileImage()
        {
            var extension = rc.Restapi().Account().Extension();

            var temp = await extension.ProfileImage().Post(bytes, "test.png");
            Assert.True(temp);

            var content = await extension.ProfileImage().Get();
            Assert.NotNull(content);
            Assert.Equal(bytes, content.data);

            var bytes4 = await extension.ProfileImage("90x90").Get();
            Assert.NotNull(bytes4);

            temp = await extension.ProfileImage().Put(bytes, "test.png");
            Assert.True(temp);

            content = await extension.ProfileImage().Get();
            Assert.NotNull(content);
            Assert.Equal(bytes, content.data);

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
            var content = await extension.MessageStore(message.id).Content(message.attachments[0].id).Get();
            var str = System.Text.Encoding.UTF8.GetString(content.data);
            Assert.NotNull(str);
            Assert.True(str.Length > 0);

            // fax
            message = messages.Where(m => m.type == "Fax" && m.attachments != null && m.attachments.Length > 0).First();
            content = await extension.MessageStore(message.id).Content(message.attachments[0].id).Get();
            Assert.NotNull(content);
            Assert.True(content.data.Length > 0);
            System.IO.File.WriteAllBytes("test.pdf", content.data);
        }

        [Fact]
        public async void RecordingContent()
        {
            var account = rc.Restapi().Account();

            // List call Logs
            var queryParams = new CallLogPath.ListParameters
            {
                type = new string[] { "Voice" },
                view = new string[] { "Detailed" },
                dateFrom = DateTime.UtcNow.AddDays(-365).ToString("o"),
                withRecording = true,
                perPage = 10,
            };
            var callLogs = await account.CallLog().List(queryParams);
            if (callLogs.records.Length > 0)
            {
                // download a call recording
                var callLog = callLogs.records[0];
                var content = await account.Recording(callLog.recording.id).Content().Get();
                Assert.NotNull(content);
                Assert.True(content.data.Length > 0);
                System.IO.File.WriteAllBytes("test.wav", content.data);
            }
        }

        public void Dispose()
        {
            Thread.Sleep(100);
        }
    }
}
