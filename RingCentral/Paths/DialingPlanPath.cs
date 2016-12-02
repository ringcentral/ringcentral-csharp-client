using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DialingPlanPath : PathSegment
    {
        internal DialingPlanPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "dialing-plan";
            }
        }
        // Get IBO Dialing Plans
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get IBO Dialing Plans
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get IBO Dialing Plans
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
            // List of countries which can be selected for a dialing plan
            public DialingPlanCountryInfo[] @records { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
        }
    }
}
