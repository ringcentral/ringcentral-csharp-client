using System.Threading.Tasks;
namespace RingCentral
{
    public partial class StatePath : PathSegment
    {
        internal StatePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "state";
            }
        }
        // Returns all the states of a certain country
        public Task<GetStateListResponse> List()
        {
            return RC.Get<GetStateListResponse>(Endpoint(false), null);
        }
        // Returns all the states of a certain country
        public Task<GetStateListResponse> List(object parameters)
        {
            return RC.Get<GetStateListResponse>(Endpoint(false), parameters);
        }
        // Returns all the states of a certain country
        public Task<GetStateListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Internal identifier of a country
            public long? @countryId { get; set; }
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // If 'True', the list of states with phone numbers available for buying is returned
            public bool? @withPhoneNumbers { get; set; }
        }
        // Returns the information on a specific state.
        public Task<GetStateInfoResponse> Get()
        {
            return RC.Get<GetStateInfoResponse>(Endpoint(true), null);
        }
    }
}
