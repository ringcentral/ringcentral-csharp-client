using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MeetingPath : Model
    {
        internal MeetingPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "meeting";
            }
        }
        public EndPath End()
        {
            return new EndPath(this);
        }
        // Create Meeting
        public Task<MeetingInfo> Post()
        {
            return RC.Post<MeetingInfo>(Endpoint(true), null);
        }
        // Create Meeting
        public Task<MeetingInfo> Post(object parameters)
        {
            return RC.Post<MeetingInfo>(Endpoint(true), parameters);
        }
        // Create Meeting
        public Task<MeetingInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Topic of a meeting
            public string @topic { get; set; }
            // Type of a meeting. 'Instant' - meeting that is instantly started as soon as the host creates it; 'Scheduled' - common scheduled meeting; 'Recurring' - a recurring meeting. If the specified meeting type is 'Scheduled' then schedule property is mandatory for request
            public string @meetingType { get; set; }
            // Password required to join a meeting. Max number of characters is 10
            public string @password { get; set; }
            // Schedule of a meeting
            public MeetingScheduleInfo @schedule { get; set; }
            // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
            public bool? @allowJoinBeforeHost { get; set; }
            // Enables starting video when host joins the meeting
            public bool? @startHostVideo { get; set; }
            // Enables starting video when participants join the meeting
            public bool? @startParticipantsVideo { get; set; }
            // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
            public string[] @audioOptions { get; set; }
        }
        // Get Meetings List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // Canonical URI of meetings resource
            public string @uri { get; set; }
            // List of extension meetings
            public MeetingInfo[] @records { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
        }
        // Delete Meeting
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Get Meeting
        public Task<MeetingInfo> Get()
        {
            return RC.Get<MeetingInfo>(Endpoint(true), null);
        }
        // Update Meeting
        public Task<MeetingInfo> Put()
        {
            return RC.Put<MeetingInfo>(Endpoint(true), null);
        }
        // Update Meeting
        public Task<MeetingInfo> Put(object parameters)
        {
            return RC.Put<MeetingInfo>(Endpoint(true), parameters);
        }
        // Update Meeting
        public Task<MeetingInfo> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // Topic of a meeting
            public string @topic { get; set; }
            // Type of a meeting. 'Instant' - meeting that is instantly started as soon as the host creates it; 'Scheduled' - common scheduled meeting; 'Recurring' - a recurring meeting. If the specified meeting type is 'Scheduled' then schedule property is mandatory for request
            public string @meetingType { get; set; }
            // Password required to join a meeting. Max number of characters is 10
            public string @password { get; set; }
            // Schedule of a meeting
            public MeetingScheduleInfo @schedule { get; set; }
            // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
            public bool? @allowJoinBeforeHost { get; set; }
            // Enables starting video when host joins the meeting
            public bool? @startHostVideo { get; set; }
            // Enables starting video when participants join the meeting
            public bool? @startParticipantsVideo { get; set; }
            // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
            public string[] @audioOptions { get; set; }
        }
    }
}
