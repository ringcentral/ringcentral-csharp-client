using System.Threading.Tasks;
namespace RingCentral
{
    public partial class SessionsPath : PathSegment
    {
        internal SessionsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "sessions";
            }
        }
        public PartiesPath Parties(string _id)
        {
            return new PartiesPath(this, _id);
        }
        // Returns the status of a call session by ID.
        public Task<CallSessionObject> Get()
        {
            return RC.Get<CallSessionObject>(Endpoint(true), null);
        }
        // Returns the status of a call session by ID.
        public Task<CallSessionObject> Get(object parameters)
        {
            return RC.Get<CallSessionObject>(Endpoint(true), parameters);
        }
        // Returns the status of a call session by ID.
        public Task<CallSessionObject> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // The date and time of a call session latest change
            public string @timestamp { get; set; }
            // The time frame of awaiting for a status change before sending the resulting one in response
            public string @timeout { get; set; }
        }
        // Drops a call session.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
