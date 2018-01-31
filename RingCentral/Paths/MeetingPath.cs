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
        //
        public Task<MeetingsResource> List()
        {
            return RC.Get<MeetingsResource>(Endpoint(false), null);
        }
        //
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
        //
        public async Task<bool> Post(object parameters)
        {
            await RC.Post(Endpoint(true), parameters);
            return true;
        }
        //
        public Task<bool> Post(MeetingRequestResource parameters)
        {
            return Post(parameters as object);
        }
        //
        public Task<MeetingResponseResource> Get()
        {
            return RC.Get<MeetingResponseResource>(Endpoint(true), null);
        }
        //
        public Task<MeetingResponseResource> Put()
        {
            return RC.Put<MeetingResponseResource>(Endpoint(true), null);
        }
        //
        public Task<MeetingResponseResource> Put(object parameters)
        {
            return RC.Put<MeetingResponseResource>(Endpoint(true), parameters);
        }
        //
        public Task<MeetingResponseResource> Put(MeetingRequestResource parameters)
        {
            return Put(parameters as object);
        }
        //
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
