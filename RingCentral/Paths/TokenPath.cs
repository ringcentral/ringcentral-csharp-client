using System.Threading.Tasks;
namespace RingCentral
{
    public partial class TokenPath : PathSegment
    {
        internal TokenPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "token";
            }
        }
        // OAuth2 Get Token
        public Task<TokenInfo> Post()
        {
            return RC.Post<TokenInfo>(Endpoint(true), null);
        }
        // OAuth2 Get Token
        public Task<TokenInfo> Post(object parameters)
        {
            return RC.Post<TokenInfo>(Endpoint(true), parameters);
        }
        // OAuth2 Get Token
        public Task<TokenInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Must hold password value for Resource Owner Credentials flow. If client application is not authorized by the specified grant_type, response does not contain refresh_token and refresh_token_ttl attributes
            public string @grant_type { get; set; }
            // Optional. Access token lifetime in seconds; the possible values are from 600 sec (10 min) to 3600 sec (1 hour). The default value is 3600 sec. If the value specified exceeds the default one, the default value is set. If the value specified is less than 600 seconds, the minimum value (600 sec) is set
            public long? @access_token_ttl { get; set; }
            // Optional. Refresh token lifetime in seconds. The default value depends on the client application, but as usual it equals to 7 days. If the value specified exceeds the default one, the default value is applied. If client specifies refresh_token_ttl<=0, refresh token is not returned even if the corresponding grant type is supported
            public long? @refresh_token_ttl { get; set; }
            // Phone number linked to account or extension in account in E.164 format with or without leading "+" sign
            public string @username { get; set; }
            // Optional. Extension short number. If company number is specified as a username, and extension is not specified, the server will attempt to authenticate client as main company administrator
            public string @extension { get; set; }
            // User's password
            public string @password { get; set; }
            // Optional. List of API permissions to be used with access token (see Application Permissions). Can be omitted when requesting all permissions defined during the application registration phase
            public string @scope { get; set; }
            // Optional. Unique identifier of a client application. You can pass it in request according to pattern [a-zA-Z0-9_\-]{1,64}. Otherwise it is auto-generated by server. The value will be returned in response in both cases
            public string @endpoint_id { get; set; }
        }
    }
}