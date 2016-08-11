
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BlockedNumber : Model
    {
        internal BlockedNumber(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "blocked-number";
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
            // Standard resource properties ID and canonical URI, see the section called “Resource Identification Properties”
            public string id { get; set; }
            // Canonical URI of a blocked number resource
            public string uri { get; set; }
            // Name assigned by a user to a blocked phone number
            public string name { get; set; }
            // Phone number to be blocked
            public string phoneNumber { get; set; }
        }
        public partial class PostResponse
        {
            // Standard resource properties ID and canonical URI, see the section called “Resource Identification Properties”
            public string id { get; set; }
            // Canonical URI of a blocked number resource
            public string uri { get; set; }
            // Name assigned by a user to a blocked phone number
            public string name { get; set; }
            // Phone number to be blocked
            public string phoneNumber { get; set; }
        }
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // List of blocked phone numbers
            public BlockedNumberInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Standard resource properties ID and canonical URI, see the section called “Resource Identification Properties”
            public string id { get; set; }
            // Canonical URI of a blocked number resource
            public string uri { get; set; }
            // Name assigned by a user to a blocked phone number
            public string name { get; set; }
            // Phone number to be blocked
            public string phoneNumber { get; set; }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public partial class PutRequest
        {
            // Standard resource properties ID and canonical URI, see the section called “Resource Identification Properties”
            public string id { get; set; }
            // Canonical URI of a blocked number resource
            public string uri { get; set; }
            // Name assigned by a user to a blocked phone number
            public string name { get; set; }
            // Phone number to be blocked
            public string phoneNumber { get; set; }
        }
        public partial class PutResponse
        {
            // Standard resource properties ID and canonical URI, see the section called “Resource Identification Properties”
            public string id { get; set; }
            // Canonical URI of a blocked number resource
            public string uri { get; set; }
            // Name assigned by a user to a blocked phone number
            public string name { get; set; }
            // Phone number to be blocked
            public string phoneNumber { get; set; }
        }
    }
}
