using System.Threading.Tasks;
namespace RingCentral
{
    public partial class TimezonePath : PathSegment
    {
        internal TimezonePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "timezone";
            }
        }
        // Get Time Zone List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Time Zone List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Time Zone List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public string @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public string @perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of timezones
            public TimezoneInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get Time Zone by ID
        public Task<TimezoneInfo> Get()
        {
            return RC.Get<TimezoneInfo>(Endpoint(true), null);
        }
    }
}
