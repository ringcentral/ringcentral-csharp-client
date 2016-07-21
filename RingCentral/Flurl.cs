using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RingCentral
{
    public static class Flurl
    {
        public static Url AppendPathSegment(this string url, string str)
        {
            return new Url(str).AppendPathSegment(str);
        }
    }

    public class Url
    {
        List<string> urls;
        Dictionary<string, string> queryParams;
        string key;
        string secret;
        string accessToken;

        public Url(string url)
        {
            urls = new List<string>();
            queryParams = new Dictionary<string, string>();
            urls.Add(url);
        }

        public string Path
        {
            get
            {
                return "/" + Uri;
            }
        }

        public string Uri
        {
            get
            {
                return string.Join("/", urls.Select(url => url.Trim(new char[] { '/' })));
            }
        }

        public Url AppendPathSegment(string str)
        {
            urls.Add(str);
            return this;
        }

        public Url SetQueryParam(string key, string value)
        {
            queryParams[key] = value;
            return this;
        }

        private static IEnumerable<KeyValuePair<string, object>> ObjectToKV(object obj)
        {
            return from prop in obj.GetType().GetProperties()
                   let val = prop.GetValue(obj, null)
                   select new KeyValuePair<string, object>(prop.Name, val);
        }

        public Url SetQueryParams(object obj)
        {
            foreach (var kv in ObjectToKV(obj))
            {
                SetQueryParam(kv.Key, kv.Value.ToString());
            }
            return this;
        }

        

        /// <summary>
		/// Implicit conversion from Url to String.
		/// </summary>
		/// <param name="url">the Url object</param>
		/// <returns>The string</returns>
		public static implicit operator string(Url url)
        {
            return string.Join("/", url.urls);
        }

        public Url WithBasicAuth(string key, string secret)
        {
            this.key = key;
            this.secret = secret;
            return this;
        }

        public async void PostUrlEncodedAsync(object requestBody)
        {
            var client = new HttpClient();
            await client.PostAsync(urls[0], new FormUrlEncodedContent(ObjectToKV(requestBody).Select(kv => new KeyValuePair<string, string>(kv.Key, kv.Value.ToString()))));
        }

        public async Task<T> PostUrlEncodedAsync<T>(object requestBody)
        {
            var client = new HttpClient();
            if (key != null)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(key + ":" + secret)));
            }
            var response = await client.PostAsync(Uri, new FormUrlEncodedContent(ObjectToKV(requestBody).Select(kv => new KeyValuePair<string, string>(kv.Key, kv.Value.ToString()))));
            var str = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(str);
        }

        public Url WithOAuthBearerToken(string accessToken)
        {
            this.accessToken = accessToken;
            return this;
        }

        public Task<HttpResponseMessage> DeleteAsync()
        {
            var client = new HttpClient();
            return client.DeleteAsync(Uri);
        }

        public Task<HttpResponseMessage> GetAsync()
        {
            var client = new HttpClient();
            return client.GetAsync(Uri);
        }

        public Task<HttpResponseMessage> PostJsonAsync(object requestBody)
        {
            var client = new HttpClient();
            return client.PostAsync(Uri, new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json"));
        }

        public Task<HttpResponseMessage> PutJsonAsync(object requestBody)
        {
            var client = new HttpClient();
            return client.PutAsync(Uri, new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json"));
        }
    }
}
