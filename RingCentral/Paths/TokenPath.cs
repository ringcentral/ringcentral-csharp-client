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
        // This endpoint supports two flows:
        //### 1) Resource Owner Password Credentials Flow
        //Issues new access and refresh tokens. Requests  to this endpoint must be authenticated with HTTP Basic scheme. The following paramters are required for this flow:
        //1. `api_key`
        //2. `api_secret`
        //3. `username`
        //4. `password`
        //This flow can use all the parameters below except for the `refresh_token` parameter which is used for the Refresh Token Flow decribed below.
        //### 2) Refresh Token Flow
        //Issues new access and refresh tokens by previously issued refresh token. Requests to this endpoint must be authenticated with HTTP Basic scheme. The following parameters are required for this flow:
        //1. `api_key`
        //2. `api_secret`
        //3. `refresh_token`
        //The only parameter used for this flow is the `refresh_token` parameter.
        public Task<TokenInfo> Post()
        {
            return RC.Post<TokenInfo>(Endpoint(true), null);
        }
    }
}
