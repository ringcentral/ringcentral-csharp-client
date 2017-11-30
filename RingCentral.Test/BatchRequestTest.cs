using System;
using System.IO;
using System.Linq;
using System.Threading;
using Xunit;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class BatchRequestTest : IDisposable
    {
        private RestClient rc;
        public BatchRequestTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public async void BatchGet()
        {
            var r = await rc.Restapi().Account().Extension().MessageStore().List();
            Assert.NotNull(r);
            var ids = r.records.Select(m => m.id).Take(3);
            var uri = rc.Restapi().Account().Extension().MessageStore(string.Join(",", ids)).Endpoint();
            Assert.NotNull(uri);
            var response = await rc.Get(uri);
            var statusCode = response.StatusCode; // check status code
            var str = await response.Content.ReadAsStringAsync(); // get response string
            Assert.NotNull(str);
        }

        [Fact]
        public async void BatchPut()
        {
            var r = await rc.Restapi().Account().Extension().MessageStore().List();
            Assert.NotNull(r);
            var ids = r.records.Select(m => m.id).Take(3);
            var uri = rc.Restapi().Account().Extension().MessageStore(string.Join(",", ids)).Endpoint();
            Assert.NotNull(uri);

            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Headers.ContentType.CharSet = "UTF-8";
            multipartFormDataContent.Headers.ContentType.MediaType = "multipart/mixed";
            foreach (var id in ids)
            {
                var jsonBody = JsonConvert.SerializeObject(new { readStatus = "Read" }, RestClient.jsonSerializerSettings);
                multipartFormDataContent.Add(new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            }

            var response = await rc.PutContent(uri, multipartFormDataContent);
            var statusCode = response.StatusCode; // check status code
            var str = await response.Content.ReadAsStringAsync(); // get response string
            Assert.NotNull(str);
        }

        public void Dispose()
        {
            Thread.Sleep(5000);
        }
    }
}
