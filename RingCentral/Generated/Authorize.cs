
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Authorize : Model
    {
        internal Authorize(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "authorize";
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
            public string response_type { get; set; }
            public string client_id { get; set; }
            public string redirect_uri { get; set; }
            public string state { get; set; }
        }
        public class PostResponse
        {
            public string code { get; set; }
            public int? expires_in { get; set; }
            public string state { get; set; }
        }
    }
}
