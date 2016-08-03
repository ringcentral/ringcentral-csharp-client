
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Revoke : Model
    {
        internal Revoke(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "revoke";
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
            public string token { get; set; }
        }
        public class PostResponse { }
    }
}
