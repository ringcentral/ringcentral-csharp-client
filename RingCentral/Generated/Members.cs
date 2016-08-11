
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Members : Model
    {
        internal Members(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "members";
            }
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public partial class ListQueryParams
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of extensions belonging to a given department
            public Department_Response_ExtensionInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
    }
}
