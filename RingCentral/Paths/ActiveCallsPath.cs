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
        // Returns records of all extension calls that are in progress, ordered by start time in descending order.
        public Task<ActiveCallsResponse> List()
        {
            return RC.Get<ActiveCallsResponse>(Endpoint(false), null);
        }
        // Returns records of all extension calls that are in progress, ordered by start time in descending order.
        public Task<ActiveCallsResponse> List(object parameters)
        {
            return RC.Get<ActiveCallsResponse>(Endpoint(false), parameters);
        }
        // Returns records of all extension calls that are in progress, ordered by start time in descending order.
        public Task<ActiveCallsResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
            public string[] @direction { get; set; }
            //
            public string @view { get; set; }
            // Call type of a record. If not specified, all call types are returned. Multiple values are accepted
            public string[] @type { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
        }
    }
}
