using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Configuration;

namespace RingCentral
{
    public partial class RestClient
    {
        static RestClient()
        {
            var jsonSerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            var jsonSerializer = new NewtonsoftJsonSerializer(jsonSerializerSettings);
            FlurlHttp.Configure(c => c.JsonSerializer = jsonSerializer);
        }

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

        public async Task<T> Post<T>(string endpoint, object requestBody, object queryParams = null)
        {
            var response = await Post(endpoint, requestBody, queryParams);
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<T> Put<T>(string endpoint, object requestBody, object queryParams = null)
        {
            var response = await Put(endpoint, requestBody, queryParams);
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }
    }
}