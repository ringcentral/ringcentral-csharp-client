using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ActiveCallsPath : PathSegment
    {
        internal ActiveCallsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "active-calls";
            }
        }
        // Get Account Active (Recent) Calls
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Account Active (Recent) Calls
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Account Active (Recent) Calls
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
            public string @direction { get; set; }
            // Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
            public string @type { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'.
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default.
            public long? @perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of call log records
            public CallLogRecord[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
    }
}
