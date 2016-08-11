
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Conferencing : Model
    {
        internal Conferencing(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "conferencing";
            }
        }
        public Task<GetResponse> Get(object queryParams)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return Get(queryParams as object);
        }
        public partial class GetQueryParams
        {
            // Internal identifier of a country. If not specified, the response is returned for the brand country
            public string countryId { get; set; }
        }
        public partial class GetResponse
        {
            // Canonical URI of a conferencing
            public string uri { get; set; }
            // Determines if host user allows conference participants to join before the host
            public bool? allowJoinBeforeHost { get; set; }
            // Access code for a host user
            public string hostCode { get; set; }
            // Internal parameter specifying conferencing engine
            public string mode { get; set; }
            // Access code for any participant
            public string participantCode { get; set; }
            // Primary conference phone number for user's home country returned in E.164 (11-digits) format
            public string phoneNumber { get; set; }
            // Short URL leading to the service web page Tap to Join for audio conference bridge
            public string tapToJoinUri { get; set; }
            // List of multiple dial-in phone numbers to connect to audio conference service, relevant for user's brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
            public ConferencingInfo_PhoneNumberInfo[] phoneNumbers { get; set; }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public partial class PutRequest
        {
            // Multiple dial-in phone numbers to connect to audio conference service, relevant for user's brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
            public Conferencing_Request_PhoneNumber[] phoneNumbers { get; set; }
            // Determines if host user allows conference participants to join before the host
            public bool? allowJoinBeforeHost { get; set; }
        }
        public partial class PutResponse
        {
            // Canonical URI of a conferencing
            public string uri { get; set; }
            // Determines if host user allows conference participants to join before the host
            public bool? allowJoinBeforeHost { get; set; }
            // Access code for a host user
            public string hostCode { get; set; }
            // Internal parameter specifying conferencing engine
            public string mode { get; set; }
            // Access code for any participant
            public string participantCode { get; set; }
            // Primary conference phone number for user's home country returned in E.164 (11-digits) format
            public string phoneNumber { get; set; }
            // Short URL leading to the service web page Tap to Join for audio conference bridge
            public string tapToJoinUri { get; set; }
            // List of multiple dial-in phone numbers to connect to audio conference service, relevant for user's brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
            public ConferencingInfo_PhoneNumberInfo[] phoneNumbers { get; set; }
        }
    }
}
