using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class RestClient
    {
        private FlurlClient GetClient(string endpoint, object queryParams)
        {
            var url = server.AppendPathSegment(endpoint).SetQueryParams(queryParams);
            var client = new FlurlClient(url);
            if (token != null)
            {
                client = client.WithOAuthBearerToken(token.access_token);
            }
            return client;
        }

        public Task<HttpResponseMessage> Get(string endpoint, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).GetAsync();
        }

        public Task<HttpResponseMessage> Post(string endpoint, object requestBody, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).PostJsonAsync(requestBody);
        }

        public Task<HttpResponseMessage> Put(string endpoint, object requestBody, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).PutJsonAsync(requestBody);
        }

        public Task<HttpResponseMessage> Delete(string endpoint, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).DeleteAsync();
        }

        public async Task<T> Get<T>(string endpoint, object queryParams = null)
        {
            var response = await Get(endpoint, queryParams);
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<byte[]> GetBinary(string endpoint, object queryParams = null)
        {
            var response = await Get(endpoint, queryParams);
            var bytes = await response.Content.ReadAsByteArrayAsync();
            return bytes;
        }

        public async Task<T> Post<T>(string endpoint, object requestBody, object queryParams = null)
        {
            var response = await Post(endpoint, requestBody, queryParams);
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<byte[]> PostBinary(string endpoint, byte[] requestBody, object queryParams = null)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Headers.ContentType.MediaType = "multipart/form-data";
            //multipartFormDataContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            //{
            //    Name = "image",
            //    FileName = "test.png",
            //};
            //multipartFormDataContent.Headers.ContentType = new MediaTypeHeaderValue("image/png");

            var content = new ByteArrayContent(requestBody);
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                 Name="image",
                 FileName = "test.png",
            };
            content.Headers.ContentType = new MediaTypeHeaderValue("image/png");
            multipartFormDataContent.Add(content);
            var response = await PostContent(endpoint, multipartFormDataContent, queryParams);
            //var response = await PostContent(endpoint, content, queryParams);
            var bytes = await response.Content.ReadAsByteArrayAsync();
            return bytes;
        }

        public Task<HttpResponseMessage> PostContent(string endpoint, HttpContent content, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).PostAsync(content);
        }

        public async Task<T> Put<T>(string endpoint, object requestBody, object queryParams = null)
        {
            var response = await Put(endpoint, requestBody, queryParams);
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<byte[]> PutBinary(string endpoint, byte[] requestBody, object queryParams = null)
        {
            var multipartFormDataContent = new MultipartFormDataContent();
            multipartFormDataContent.Add(new ByteArrayContent(requestBody));
            var response = await PutContent(endpoint, multipartFormDataContent, queryParams);
            var bytes = await response.Content.ReadAsByteArrayAsync();
            return bytes;
        }

        public Task<HttpResponseMessage> PutContent(string endpoint, HttpContent content, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).PutAsync(content);
        }
    }
}