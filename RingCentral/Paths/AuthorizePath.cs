using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AuthorizePath : Model
    {
        internal AuthorizePath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "authorize";
            }
        }
        // OAuth2 Authorize
        public Task<PostResponse> Post()
        {
            return RC.Post<PostResponse>(Endpoint(true), null);
        }
        // OAuth2 Authorize
        public Task<PostResponse> Post(object parameters)
        {
            return RC.Post<PostResponse>(Endpoint(true), parameters);
        }
        // OAuth2 Authorize
        public Task<PostResponse> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Must be set to code
            public string @response_type { get; set; }
            // Required. Enter your application key (Production or Sandbox) here
            public string @client_id { get; set; }
            // Required. This is a callback URI which determines where the response will be sent to. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration. This URI can be HTTP/HTTPS address for web applications or custom scheme URI for mobile or desktop applications.
            public string @redirect_uri { get; set; }
            // Optional, recommended. An opaque value used by the client to maintain state between the request and callback. The authorization server includes this value when redirecting the user-agent back to the client. The parameter should be used for preventing cross-site request forgery
            public string @state { get; set; }
        }
        public partial class PostResponse
        {
            // The authorization code returned for your application
            public string @code { get; set; }
            // The remaining lifetime of the authorization code
            public long? @expires_in { get; set; }
            // This parameter will be included in response if it was specified in the client authorization request. The value will be copied from the one received from the client
            public string @state { get; set; }
        }
    }
}
