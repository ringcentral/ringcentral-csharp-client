
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ForwardingNumber : Model
    {
        internal ForwardingNumber(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "forwarding-number";
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
            // Forwarding/Call flip phone number
            public string phoneNumber { get; set; }
            // Forwarding/Call flip number title
            public string label { get; set; }
        }
        public partial class PostResponse
        {
            // Internal identifier of a forwarding/call flip phone number
            public string id { get; set; }
            // Canonical URI of a forwarding/call flip phone number
            public string uri { get; set; }
            // Forwarding/Call flip phone number
            public string phoneNumber { get; set; }
            // Forwarding/Call flip number title
            public string label { get; set; }
            // Type of option this phone number is used for. Multiple values are accepted
            public string features { get; set; }
            // Number assigned to the call flip phone number, corresponds to the shortcut dial number
            public long? flipNumber { get; set; }
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public partial class ListQueryParams
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of forwarding phone numbers
            public ForwardingNumberInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
    }
}
