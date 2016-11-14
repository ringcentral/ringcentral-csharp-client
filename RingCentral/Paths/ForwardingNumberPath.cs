using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ForwardingNumberPath : Model
    {
        internal ForwardingNumberPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "forwarding-number";
            }
        }
        // Add New Forwarding Number
        public Task<ForwardingNumberInfo> Post()
        {
            return RC.Post<ForwardingNumberInfo>(Endpoint(true), null);
        }
        // Add New Forwarding Number
        public Task<ForwardingNumberInfo> Post(object parameters)
        {
            return RC.Post<ForwardingNumberInfo>(Endpoint(true), parameters);
        }
        // Add New Forwarding Number
        public Task<ForwardingNumberInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Forwarding/Call flip phone number
            public string @phoneNumber { get; set; }
            // Forwarding/Call flip number title
            public string @label { get; set; }
        }
        // Get Forwarding Numbers
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Forwarding Numbers
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Forwarding Numbers
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of forwarding phone numbers
            public ForwardingNumberInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
    }
}
