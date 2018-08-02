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
        // Returns the information on the Free Conference Calling (FCC) feature for a given extension.
        public Task<GetConferencingInfoResponse> Get()
        {
            return RC.Get<GetConferencingInfoResponse>(Endpoint(true), null);
        }
        // Returns the information on the Free Conference Calling (FCC) feature for a given extension.
        public Task<GetConferencingInfoResponse> Get(object parameters)
        {
            return RC.Get<GetConferencingInfoResponse>(Endpoint(true), parameters);
        }
        // Returns the information on the Free Conference Calling (FCC) feature for a given extension.
        public Task<GetConferencingInfoResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Internal identifier of a country. If not specified, the response is returned for the brand country
            public string @countryId { get; set; }
        }
        // Updates the default conferencing number for the current extension. The number can be selected from conferencing numbers of the current extension. Updates the setting, allowing participants join the conference before host.
        public Task<GetConferencingInfoResponse> Put()
        {
            return RC.Put<GetConferencingInfoResponse>(Endpoint(true), null);
        }
        // Updates the default conferencing number for the current extension. The number can be selected from conferencing numbers of the current extension. Updates the setting, allowing participants join the conference before host.
        public Task<GetConferencingInfoResponse> Put(object parameters)
        {
            return RC.Put<GetConferencingInfoResponse>(Endpoint(true), parameters);
        }
        // Updates the default conferencing number for the current extension. The number can be selected from conferencing numbers of the current extension. Updates the setting, allowing participants join the conference before host.
        public Task<GetConferencingInfoResponse> Put(UpdateConferencingInfoRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
