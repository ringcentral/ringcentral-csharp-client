
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Token : Model
    {
        internal Token(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "token";
            }
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public class PostRequest
        {
            public string grant_type { get; set; }
            public int? access_token_ttl { get; set; }
            public int? refresh_token_ttl { get; set; }
            public string username { get; set; }
            public string extension { get; set; }
            public string password { get; set; }
            public string scope { get; set; }
            public string endpoint_id { get; set; }
        }
        public class PostResponse
        {
            public string access_token { get; set; }
            public int? expires_in { get; set; }
            public string refresh_token { get; set; }
            public int? refresh_token_expires_in { get; set; }
            public string scope { get; set; }
            public string token_type { get; set; }
            public string owner_id { get; set; }
            public string endpoint_id { get; set; }
        }
    }
}
