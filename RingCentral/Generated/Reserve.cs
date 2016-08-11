
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Reserve : Model
    {
        internal Reserve(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "reserve";
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
        public partial class PostRequest
        {
            // Phone numbers to be reserved/un-reserved
            public ReservePhoneNumber_Request_ReserveRecord[] records { get; set; }
        }
        public partial class PostResponse
        {
            // Phone numbers to be reserved/un-reserved
            public ReservePhoneNumber_Response_ReserveRecord[] records { get; set; }
        }
    }
}
