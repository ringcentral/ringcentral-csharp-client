using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Fax
    {
        public Task<PostResponse> Post(object requestBody, IEnumerable<Attachment> attachments)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Headers.ContentType.CharSet = "UTF-8";
            multipartFormDataContent.Headers.ContentType.MediaType = "multipart/mixed";
            var jsonBody = JsonConvert.SerializeObject(requestBody, RestClient.jsonSerializerSettings);
            multipartFormDataContent.Add(new StringContent(jsonBody, Encoding.UTF8, "application/json"));
            foreach (var attachment in attachments)
            {
                var fileContent = new ByteArrayContent(attachment.bytes);
                fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = attachment.fileName
                };
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(attachment.contentType);
                multipartFormDataContent.Add(fileContent);
            }
            return RC.PostContent<PostResponse>(Endpoint(false), multipartFormDataContent);
        }
        public Task<PostResponse> Post(PostRequest requestBody, IEnumerable<Attachment> attachments)
        {
            return Post(requestBody as object, attachments);
        }
    }

    public class Attachment
    {
        public string fileName { get; set; }
        public string contentType { get; set; }
        public byte[] bytes { get; set; }
    }
}
