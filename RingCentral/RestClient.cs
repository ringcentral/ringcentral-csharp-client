using Flurl;
using Flurl.Http;
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
            var url = new Url(server).AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new
            {
                username = username,
                extension = extension,
                password = password,
                grant_type = "password"
            };
            token = client.PostUrlEncodedAsync(requestBody).ReceiveJson<Token.PostResponse>().Result;
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
            var requestBody = new
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

        /// <summary>
        /// Do authorization with the authorization code returned from server
        /// </summary>
        /// <param name="authCode">The authorization code returned from server</param>
        /// <param name="redirectUri">The same redirectUri when you were obtaining the authCode in previous step</param>
        public void Authorize(string authCode, string redirectUri)
        {
            var url = new Url(server).AppendPathSegment("/restapi/oauth/token");
            var client = url.WithBasicAuth(appKey, appSecret);
            var requestBody = new
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