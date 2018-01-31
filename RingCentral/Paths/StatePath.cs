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
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the states for a certain country.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetStateListResponse> List()
        {
            return RC.Get<GetStateListResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the states for a certain country.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetStateListResponse> List(object parameters)
        {
            return RC.Get<GetStateListResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all the states for a certain country.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetStateListResponse> List(ListParameters parameters)
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
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns the information on the required state.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetStateInfoResponse> Get()
        {
            return RC.Get<GetStateInfoResponse>(Endpoint(true), null);
        }
    }
}
