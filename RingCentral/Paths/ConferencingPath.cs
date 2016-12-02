using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ConferencingPath : PathSegment
    {
        internal ConferencingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "conferencing";
            }
        }
        // Get Conferencing info
        public Task<ConferencingInfo> Get()
        {
            return RC.Get<ConferencingInfo>(Endpoint(true), null);
        }
        // Get Conferencing info
        public Task<ConferencingInfo> Get(object parameters)
        {
            return RC.Get<ConferencingInfo>(Endpoint(true), parameters);
        }
        // Get Conferencing info
        public Task<ConferencingInfo> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Internal identifier of a country. If not specified, the response is returned for the brand country
            public string @countryId { get; set; }
        }
        // Update Conferencing info
        public Task<ConferencingInfo> Put()
        {
            return RC.Put<ConferencingInfo>(Endpoint(true), null);
        }
        // Update Conferencing info
        public Task<ConferencingInfo> Put(object parameters)
        {
            return RC.Put<ConferencingInfo>(Endpoint(true), parameters);
        }
        // Update Conferencing info
        public Task<ConferencingInfo> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // Multiple dial-in phone numbers to connect to audio conference service, relevant for user's brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
            public Conferencing_Request_PhoneNumber[] @phoneNumbers { get; set; }
            // Determines if host user allows conference participants to join before the host
            public bool? @allowJoinBeforeHost { get; set; }
        }
    }
}
