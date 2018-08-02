using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MeetingPath : PathSegment
    {
        internal MeetingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
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
        // Returns a list of meetings for a particular extension. The list of meetings does not include meetings of 'Instant' type.
        public Task<MeetingsResource> List()
        {
            return RC.Get<MeetingsResource>(Endpoint(false), null);
        }
        // Creates a new meeting.
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
        // Creates a new meeting.
        public async Task<bool> Post(object parameters)
        {
            await RC.Post(Endpoint(true), parameters);
            return true;
        }
        // Creates a new meeting.
        public Task<bool> Post(MeetingRequestResource parameters)
        {
            return Post(parameters as object);
        }
        // Returns a particular meetings details by ID.
        public Task<MeetingResponseResource> Get()
        {
            return RC.Get<MeetingResponseResource>(Endpoint(true), null);
        }
        // Modifies a particular meeting.
        public Task<MeetingResponseResource> Put()
        {
            return RC.Put<MeetingResponseResource>(Endpoint(true), null);
        }
        // Modifies a particular meeting.
        public Task<MeetingResponseResource> Put(object parameters)
        {
            return RC.Put<MeetingResponseResource>(Endpoint(true), parameters);
        }
        // Modifies a particular meeting.
        public Task<MeetingResponseResource> Put(MeetingRequestResource parameters)
        {
            return Put(parameters as object);
        }
        // Deletes a scheduled meeting.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
