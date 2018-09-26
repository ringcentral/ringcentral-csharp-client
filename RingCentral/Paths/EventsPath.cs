using System.Threading.Tasks;
namespace RingCentral
{
    public partial class EventsPath : PathSegment
    {
        internal EventsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "events";
            }
        }
        // Returns all events created by the current user.
        public Task<GlipEventsInfo> List()
        {
            return RC.Get<GlipEventsInfo>(Endpoint(false), null);
        }
        // Creates a new event.
        public Task<GlipEventInfo> Post()
        {
            return RC.Post<GlipEventInfo>(Endpoint(true), null);
        }
        // Creates a new event.
        public Task<GlipEventInfo> Post(object parameters)
        {
            return RC.Post<GlipEventInfo>(Endpoint(true), parameters);
        }
        // Creates a new event.
        public Task<GlipEventInfo> Post(GlipEventCreate parameters)
        {
            return Post(parameters as object);
        }
        // Returns event(s) with given id(s).
        public Task<GlipEventInfo> Get()
        {
            return RC.Get<GlipEventInfo>(Endpoint(true), null);
        }
        // Updates an event by ID.
        public async Task<bool> Put()
        {
            await RC.Put(Endpoint(true), null);
            return true;
        }
        // Updates an event by ID.
        public async Task<bool> Put(object parameters)
        {
            await RC.Put(Endpoint(true), parameters);
            return true;
        }
        // Updates an event by ID.
        public Task<bool> Put(GlipEventCreate parameters)
        {
            return Put(parameters as object);
        }
        // Deletes an event by the specified ID.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
