using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CountryPath : Model
    {
        internal CountryPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "country";
            }
        }
        // Get Country List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Country List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Country List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Specifies whether login with the phone numbers of this country is enabled or not
            public bool? @loginAllowed { get; set; }
            // Specifies if RingCentral sells phone numbers of this country
            public bool? @numberSelling { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of countries with the country data
            public FullCountryInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get Country by ID
        public Task<FullCountryInfo> Get()
        {
            return RC.Get<FullCountryInfo>(Endpoint(true), null);
        }
    }
}
