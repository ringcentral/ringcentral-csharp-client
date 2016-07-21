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
            return new Url(url).AppendPathSegment(str);
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
                var result = string.Join("/", urls.Where(url => !string.IsNullOrWhiteSpace(url)).Select(url => url.Trim(new char[] { '/' })));
                if (queryParams.Count > 0)
                {
                    result += "?" + string.Join("&", queryParams.Where(kv => !string.IsNullOrWhiteSpace(kv.Value)).Select(kv => $"{kv.Key}={System.Uri.EscapeDataString(kv.Value)}"));
                }
                return result;
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
            if (obj != null)
            {
                foreach (var kv in ObjectToKV(obj))
                {
                    SetQueryParam(kv.Key, kv.Value.ToString());
                }
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
            return url.Uri;
        }

        public Url WithBasicAuth(string key, string secret)
        {
            this.key = key;
            this.secret = secret;
            return this;
        }

        public async void PostUrlEncodedAsync(object requestBody)
        {
            var client = GetClient();
            await client.PostAsync(Uri, new FormUrlEncodedContent(ObjectToKV(requestBody).Select(kv => new KeyValuePair<string, string>(kv.Key, kv.Value.ToString()))));
        }

        public async Task<T> PostUrlEncodedAsync<T>(object requestBody)
        {
            var client = GetClient();

            var response = await client.PostAsync(Uri, new FormUrlEncodedContent(ObjectToKV(requestBody).Select(kv => new KeyValuePair<string, string>(kv.Key, kv.Value.ToString()))));
            var str = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(str);
        }

        public Url WithOAuthBearerToken(string accessToken)
        {
            this.accessToken = accessToken;
            return this;
        }

        private HttpClient GetClient()
        {
            var client = new HttpClient();
            if (key != null)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(key + ":" + secret)));
            }
            if (accessToken != null)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }
            return client;
        }

        public Task<HttpResponseMessage> DeleteAsync()
        {
            var client = GetClient();
            return client.DeleteAsync(Uri);
        }

        public Task<HttpResponseMessage> GetAsync()
        {
            var client = GetClient();
            return client.GetAsync(Uri);
        }

        private string ToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public Task<HttpResponseMessage> PostJsonAsync(object requestBody)
        {
            var client = GetClient();
            return client.PostAsync(Uri, new StringContent(ToJson(requestBody), Encoding.UTF8, "application/json"));
        }

        public Task<HttpResponseMessage> PutJsonAsync(object requestBody)
        {
            var client = GetClient();
            return client.PutAsync(Uri, new StringContent(ToJson(requestBody), Encoding.UTF8, "application/json"));
        }
    }
}
