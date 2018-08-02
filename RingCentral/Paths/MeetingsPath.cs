using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MeetingsPath : PathSegment
    {
        internal MeetingsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "meetings";
            }
        }
        // Returns Zoom meetings presence status of an extension
        public Task<MeetingsPresence> Get()
        {
            return RC.Get<MeetingsPresence>(Endpoint(true), null);
        }
        // Set Zoom meetings presence status of an extension
        public Task<MeetingsPresence> Post()
        {
            return RC.Post<MeetingsPresence>(Endpoint(true), null);
        }
        // Set Zoom meetings presence status of an extension
        public Task<MeetingsPresence> Post(object parameters)
        {
            return RC.Post<MeetingsPresence>(Endpoint(true), parameters);
        }
        // Set Zoom meetings presence status of an extension
        public Task<MeetingsPresence> Post(MeetingsPresence parameters)
        {
            return Post(parameters as object);
        }
    }
}
