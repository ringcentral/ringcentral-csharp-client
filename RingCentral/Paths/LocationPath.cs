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
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the available locations for the certain state.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetLocationListResponse> List()
        {
            return RC.Get<GetLocationListResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the available locations for the certain state.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetLocationListResponse> List(object parameters)
        {
            return RC.Get<GetLocationListResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the available locations for the certain state.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetLocationListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Sorts results by the specified property. The default value is 'City'
            public string[] @orderBy { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'.
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default.
            public long? @perPage { get; set; }
            // Internal identifier of a state
            public string @stateId { get; set; }
            // Specifies if nxx codes are returned
            public bool? @withNxx { get; set; }
        }
    }
}
