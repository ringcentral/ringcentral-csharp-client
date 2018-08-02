using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LocationPath : PathSegment
    {
        internal LocationPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "location";
            }
        }
        // Returns all available locations for a certain state.
        public Task<GetLocationListResponse> List()
        {
            return RC.Get<GetLocationListResponse>(Endpoint(false), null);
        }
        // Returns all available locations for a certain state.
        public Task<GetLocationListResponse> List(object parameters)
        {
            return RC.Get<GetLocationListResponse>(Endpoint(false), parameters);
        }
        // Returns all available locations for a certain state.
        public Task<GetLocationListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Sorts results by the property specified
            public string[] @orderBy { get; set; }
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // Internal identifier of a state
            public string @stateId { get; set; }
            // Specifies if nxx codes are returned
            public bool? @withNxx { get; set; }
        }
    }
}
