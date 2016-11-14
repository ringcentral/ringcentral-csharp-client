using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System.Net.Http;
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

        public async Task<T> Get<T>(string endpoint, object queryParams = null) where T: class
        {
            if (typeof(Binary) == typeof(T))
            {
                var bytes = await GetBinary(endpoint, queryParams);
                var binary = new Binary { data = bytes };
                return binary as T;
            }
            else
            {
                var response = await Get(endpoint, queryParams);
                var str = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(str);
            }
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
            var str = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(str);
        }

        public Task<HttpResponseMessage> PostContent(string endpoint, HttpContent content, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).PostAsync(content);
        }

        public async Task<T> Put<T>(string endpoint, object requestBody, object queryParams = null)
        {
            var response = await Put(endpoint, requestBody, queryParams);
            var str = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(str);
        }

        public Task<HttpResponseMessage> PutContent(string endpoint, HttpContent content, object queryParams = null)
        {
            return GetClient(endpoint, queryParams).PutAsync(content);
        }
    }
}