using System.Threading.Tasks;
namespace RingCentral
{
    public partial class StatePath : Model
    {
        internal StatePath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "state";
            }
        }
        // Get State/Province List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get State/Province List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get State/Province List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Internal identifier of a country
            public long? @countryId { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'.
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
            // If 'True', the list of states with phone numbers available for buying is returned. The default value is 'False'
            public bool? @withPhoneNumbers { get; set; }
        }
        public partial class ListResponse
        {
            // List of states
            public StateInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get State/Province by ID
        public Task<StateInfo> Get()
        {
            return RC.Get<StateInfo>(Endpoint(true), null);
        }
    }
}
