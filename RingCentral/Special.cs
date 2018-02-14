using Flurl.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RingCentral
{
    // Extension put requestBody is an enum
    public interface ExtensionParameters { }
    public partial class ExtensionInfo_Request_StatusInfo : ExtensionParameters { }
    public partial class ExtensionInfo_Request_ContactInfo : ExtensionParameters { }
    public partial class ExtensionInfo_Request_PasswordPIN : ExtensionParameters { }
    public partial class ExtensionInfo_Request_PartnerId : ExtensionParameters { }
    public partial class ExtensionInfo_Request_Provision : ExtensionParameters { }


    // fax
    public partial class FaxPath
    {
        public Task<FaxResponse> Post(object requestBody, IEnumerable<Attachment> attachments)
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
            return RC.PostContent(Endpoint(false), multipartFormDataContent).ReceiveJson<FaxResponse>();
        }
        //public Task<MessageInfo> Post(PostParameters requestBody, IEnumerable<Attachment> attachments)
        //{
        //    return Post(requestBody as object, attachments);
        //}
    }
    public class Attachment
    {
        public string fileName { get; set; }
        public string contentType { get; set; }
        public byte[] bytes { get; set; }
    }


    // Upload profile image
    public partial class ProfileImagePath
    {
        private MultipartFormDataContent GetContent(byte[] bytes, string imageFileName)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Headers.ContentType.MediaType = "multipart/form-data";
            var byteArrayContent = new ByteArrayContent(bytes);
            byteArrayContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "image",
                FileName = imageFileName,
            };
            byteArrayContent.Headers.ContentType = new MediaTypeHeaderValue("image/" + Path.GetExtension(imageFileName).Substring(1));
            multipartFormDataContent.Add(byteArrayContent);
            return multipartFormDataContent;
        }

        public async Task<bool> Post(byte[] requestBody, string imageFileName)
        {
            var content = GetContent(requestBody, imageFileName);
            var response = await RC.PostContent(Endpoint(false), content);
            return true;
        }

        public async Task<bool> Put(byte[] requestBody, string imageFileName)
        {
            var content = GetContent(requestBody, imageFileName);
            var response = await RC.PutContent(Endpoint(false), content);
            return true;
        }
    }
}
