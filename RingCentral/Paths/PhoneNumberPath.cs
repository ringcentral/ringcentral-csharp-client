using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PhoneNumberPath : PathSegment
    {
        internal PhoneNumberPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "phone-number";
            }
        }
        // Get Extension Phone Numbers
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Extension Phone Numbers
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Extension Phone Numbers
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Usage type of the phone number
            public string @usageType { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of phone numbers
            public PhoneNumberInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get Phone Number by ID
        public Task<PhoneNumberInfo> Get()
        {
            return RC.Get<PhoneNumberInfo>(Endpoint(true), null);
        }
    }
}
