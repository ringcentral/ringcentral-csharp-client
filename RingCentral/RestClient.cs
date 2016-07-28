using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace RingCentral
{
    public partial class RestClient
    {
        public const string SandboxServer = "https://platform.devtest.ringcentral.com";
        public const string ProductionServer = "https://platform.ringcentral.com";

        public string appKey;
        public string appSecret;
        public string server;

        static RestClient()
        {
            var jsonSerializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            var jsonSerializer = new NewtonsoftJsonSerializer(jsonSerializerSettings);
            FlurlHttp.Configure(c => c.JsonSerializer = jsonSerializer);
        }

        public RestClient(string appKey, string appSecret, string server)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.server = server;
        }
        public RestClient(string appKey, string appSecret, bool production = false)
            : this(appKey, appSecret, production ? ProductionServer : SandboxServer)
        {
        }


        private bool refreshScheduled = false;
        private Token.PostResponse _token;
        public Token.PostResponse token
        {
            get
            {
                return _token;
            }
            set
            {
                _token = value;
                if (_token != null)
                {
                    if (!refreshScheduled)
                    { // don't do duplicate schedule
                        Task.Delay((_token.expires_in.Value - 120) * 1000).ContinueWith((action) =>
                        { // 2 minutes before expiration
                            refreshScheduled = false;
                            Refresh();
                        });
                        refreshScheduled = true;
                    }
                }
            }
        }

        /// <summary>
        /// Password authorization
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="extension">Extension, can be null or empty</param>
        /// <param name="password">Password</param>
        public void Authorize(string username, string extension, string password)
        {
            var url = server.AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new Token.PostRequest
            {
                username = username,
                extension = extension,
                password = password,
                grant_type = "password"
            };
            token = client.PostUrlEncodedAsync(requestBody).ReceiveJson<Token.PostResponse>().Result;
        }

        public class RefreshRequest
        {
            public string grant_type { get; set; }
            public string refresh_token { get; set; }
            public string endpoint_id { get; set; }
        }
        /// <summary>
        /// Refresh the token
        /// </summary>
        private void Refresh()
        {
            if (token == null)
            {
                return;
            }
            var url = new Url(server).AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new RefreshRequest
            {
                grant_type = "refresh_token",
                refresh_token = token.refresh_token,
                endpoint_id = token.endpoint_id
            };
            token = client.PostUrlEncodedAsync(requestBody).ReceiveJson<Token.PostResponse>().Result;
        }


        /// <summary>
        /// When your application needs to authorize an user, redirect the user to RingCentral API server for authorization.
        /// This method helps you to build the URI. Later you can redirect user to this URI.
        /// </summary>
        /// <param name="redirectUri">This is a callback URI which determines where the response will be sent to. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration. This URI can be HTTP/HTTPS address for web applications or custom scheme URI for mobile or desktop applications.</param>
        /// <param name="state">Optional, recommended. An opaque value used by the client to maintain state between the request and callback. The authorization server includes this value when redirecting the user-agent back to the client. The parameter should be used for preventing cross-site request forgery</param>
        /// <returns>Uri for 3-legged authorization</returns>
        public string AuthorizeUri(string redirectUri, string state = "")
        {
            var baseUrl = new Url(server).AppendPathSegment("/restapi/oauth/authorize");
            baseUrl.SetQueryParam("response_type", "code");
            baseUrl.SetQueryParam("state", state);
            baseUrl.SetQueryParam("redirect_uri", redirectUri);
            baseUrl.SetQueryParam("client_id", appKey);
            return baseUrl.ToString();
        }


        public class AuthCodeRequest
        {
            public string grant_type { get; set; }
            public string redirect_uri { get; set; }
            public string code { get; set; }
        }
        /// <summary>
        /// Do authorization with the authorization code returned from server
        /// </summary>
        /// <param name="authCode">The authorization code returned from server</param>
        /// <param name="redirectUri">The same redirectUri when you were obtaining the authCode in previous step</param>
        public void Authorize(string authCode, string redirectUri)
        {
            var url = new Url(server).AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new AuthCodeRequest
            {
                grant_type = "authorization_code",
                redirect_uri = redirectUri,
                code = authCode
            };
            token = client.PostUrlEncodedAsync(requestBody).ReceiveJson<Token.PostResponse>().Result;
        }

        /// <summary>
        /// Revoke acess token
        /// </summary>
        public void Revoke()
        {
            if (token == null)
            {
                return;
            }
            var url = new Url(server).AppendPathSegment("/restapi/oauth/revoke");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new { token = token.access_token };
            client.PostUrlEncodedAsync(requestBody);
            token = null;
        }


        public Restapi Restapi(string _id = "v1.0")
        {
            return new Restapi(new MockModel(this), _id);
        }
    }
}