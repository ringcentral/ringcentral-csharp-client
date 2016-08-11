
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Country : Model
    {
        internal Country(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "country";
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
            // Specifies whether login with the phone numbers of this country is enabled or not
            public bool? loginAllowed { get; set; }
            // Specifies if RingCentral sells phone numbers of this country
            public bool? numberSelling { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of countries with the country data
            public FullCountryInfo[] records { get; set; }
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
            // Internal identifier of a country
            public string id { get; set; }
            // Canonical URI of a country
            public string uri { get; set; }
            // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
            public string callingCode { get; set; }
            // Emergency calling feature availability/emergency address requirement indicator
            public bool? emergencyCalling { get; set; }
            // Country code according to the ISO standard, see ISO 3166
            public string isoCode { get; set; }
            // Official name of a country
            public string name { get; set; }
            // Determines whether phone numbers are available for a country
            public bool? numberSelling { get; set; }
            // Specifies whether login with the phone numbers of this country is enabled or not
            public bool? loginAllowed { get; set; }
        }
    }
}
