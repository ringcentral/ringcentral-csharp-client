using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LocationPath : Model
    {
        internal LocationPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "location";
            }
        }
        // Get Location List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Location List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Location List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Sorts results by the specified property. The default value is 'City'
            public string @orderBy { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'.
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default.
            public long? @perPage { get; set; }
            // Internal identifier of a state
            public string @stateId { get; set; }
            // Specifies if nxx codes are returned
            public bool? @withNxx { get; set; }
        }
        public partial class ListResponse
        {
            // List of locations
            public LocationInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
    }
}
