
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Meeting : Model
    {
        internal Meeting(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "meeting";
            }
        }
        public ServiceInfo ServiceInfo()
        {
            return new ServiceInfo(this);
        }
        public End End()
        {
            return new End(this);
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public partial class PostRequest
        {
            // Topic of a meeting
            public string topic { get; set; }
            // Type of a meeting. 'Instant' - meeting that is instantly started as soon as the host creates it; 'Scheduled' - common scheduled meeting; 'Recurring' - a recurring meeting. If the specified meeting type is 'Scheduled' then schedule property is mandatory for request
            public string meetingType { get; set; }
            // Password required to join a meeting. Max number of characters is 10
            public string password { get; set; }
            // Schedule of a meeting
            public MeetingScheduleInfo schedule { get; set; }
            // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
            public bool? allowJoinBeforeHost { get; set; }
            // Enables starting video when host joins the meeting
            public bool? startHostVideo { get; set; }
            // Enables starting video when participants join the meeting
            public bool? startParticipantsVideo { get; set; }
            // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
            public string[] audioOptions { get; set; }
        }
        public partial class PostResponse
        {
            // Canonical URI of a meeting resource
            public string uri { get; set; }
            // Internal identifier of a meeting as retrieved from Zoom
            public string id { get; set; }
            // Topic of a meeting
            public string topic { get; set; }
            // Type of a meeting
            public string meetingType { get; set; }
            // Password required to join a meeting
            public string password { get; set; }
            // Current status of a meeting
            public string status { get; set; }
            // Links to start/join the meeting
            public LinksInfo links { get; set; }
            // Schedule of a meeting
            public MeetingScheduleInfo schedule { get; set; }
            // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
            public bool? allowJoinBeforeHost { get; set; }
            // Enables starting video when host joins the meeting
            public bool? startHostVideo { get; set; }
            // Enables starting video when participants join the meeting
            public bool? startParticipantsVideo { get; set; }
            // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
            public string[] audioOptions { get; set; }
        }
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // Canonical URI of meetings resource
            public string uri { get; set; }
            // List of extension meetings
            public MeetingInfo[] records { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Canonical URI of a meeting resource
            public string uri { get; set; }
            // Internal identifier of a meeting as retrieved from Zoom
            public string id { get; set; }
            // Topic of a meeting
            public string topic { get; set; }
            // Type of a meeting
            public string meetingType { get; set; }
            // Password required to join a meeting
            public string password { get; set; }
            // Current status of a meeting
            public string status { get; set; }
            // Links to start/join the meeting
            public LinksInfo links { get; set; }
            // Schedule of a meeting
            public MeetingScheduleInfo schedule { get; set; }
            // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
            public bool? allowJoinBeforeHost { get; set; }
            // Enables starting video when host joins the meeting
            public bool? startHostVideo { get; set; }
            // Enables starting video when participants join the meeting
            public bool? startParticipantsVideo { get; set; }
            // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
            public string[] audioOptions { get; set; }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public partial class PutRequest
        {
            // Topic of a meeting
            public string topic { get; set; }
            // Type of a meeting. 'Instant' - meeting that is instantly started as soon as the host creates it; 'Scheduled' - common scheduled meeting; 'Recurring' - a recurring meeting. If the specified meeting type is 'Scheduled' then schedule property is mandatory for request
            public string meetingType { get; set; }
            // Password required to join a meeting. Max number of characters is 10
            public string password { get; set; }
            // Schedule of a meeting
            public MeetingScheduleInfo schedule { get; set; }
            // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
            public bool? allowJoinBeforeHost { get; set; }
            // Enables starting video when host joins the meeting
            public bool? startHostVideo { get; set; }
            // Enables starting video when participants join the meeting
            public bool? startParticipantsVideo { get; set; }
            // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
            public string[] audioOptions { get; set; }
        }
        public partial class PutResponse
        {
            // Canonical URI of a meeting resource
            public string uri { get; set; }
            // Internal identifier of a meeting as retrieved from Zoom
            public string id { get; set; }
            // Topic of a meeting
            public string topic { get; set; }
            // Type of a meeting
            public string meetingType { get; set; }
            // Password required to join a meeting
            public string password { get; set; }
            // Current status of a meeting
            public string status { get; set; }
            // Links to start/join the meeting
            public LinksInfo links { get; set; }
            // Schedule of a meeting
            public MeetingScheduleInfo schedule { get; set; }
            // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
            public bool? allowJoinBeforeHost { get; set; }
            // Enables starting video when host joins the meeting
            public bool? startHostVideo { get; set; }
            // Enables starting video when participants join the meeting
            public bool? startParticipantsVideo { get; set; }
            // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
            public string[] audioOptions { get; set; }
        }
    }
}
