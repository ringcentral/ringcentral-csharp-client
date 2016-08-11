
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class State : Model
    {
        internal State(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "state";
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
            // Internal identifier of a country
            public int? countryId { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'.
            public int? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public int? perPage { get; set; }
            // If 'True', the list of states with phone numbers available for buying is returned. The default value is 'False'
            public bool? withPhoneNumbers { get; set; }
        }
        public partial class ListResponse
        {
            // List of states
            public StateInfo[] records { get; set; }
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
            // Internal identifier of a state
            public string id { get; set; }
            // Canonical URI of a state
            public string uri { get; set; }
            // Information on a country the state belongs to
            public StateInfo_CountryInfo country { get; set; }
            // Short code for a state (2-letter usually)
            public string isoCode { get; set; }
            // Official name of a state
            public string name { get; set; }
        }
    }
}
