using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class ProfileImage
    {
        public Task<byte[]> Get()
        {
            return RC.GetBinary(Endpoint(true), null);
        }

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

        public async Task<byte[]> Post(byte[] requestBody, string imageFileName)
        {
            var content = GetContent(requestBody, imageFileName);
            var response = await RC.PostContent(Endpoint(false), content);
            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<byte[]> Put(byte[] requestBody, string imageFileName)
        {
            var content = GetContent(requestBody, imageFileName);
            var response = await RC.PutContent(Endpoint(false), content);
            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
