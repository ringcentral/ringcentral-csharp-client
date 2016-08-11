
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Timezone : Model
    {
        internal Timezone(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "timezone";
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
            public string page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public string perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of timezones
            public TimezoneInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of a timezone
            public string id { get; set; }
            // Canonical URI of a timezone
            public string uri { get; set; }
            // Short name of a timezone
            public string name { get; set; }
            // Meaningful description of the timezone
            public string description { get; set; }
        }
    }
}
