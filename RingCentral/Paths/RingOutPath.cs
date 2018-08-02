using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RingOutPath : PathSegment
    {
        internal RingOutPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "ring-out";
            }
        }
        // Makes a 2-leg RingOut call.
        public Task<GetRingOutStatusResponse> Post()
        {
            return RC.Post<GetRingOutStatusResponse>(Endpoint(true), null);
        }
        // Makes a 2-leg RingOut call.
        public Task<GetRingOutStatusResponse> Post(object parameters)
        {
            return RC.Post<GetRingOutStatusResponse>(Endpoint(true), parameters);
        }
        // Makes a 2-leg RingOut call.
        public Task<GetRingOutStatusResponse> Post(MakeRingOutRequest parameters)
        {
            return Post(parameters as object);
        }
        // Returns the status of a 2-leg RingOut call.
        public Task<GetRingOutStatusResponse> Get()
        {
            return RC.Get<GetRingOutStatusResponse>(Endpoint(true), null);
        }
        // Cancels a 2-leg RingOut call.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
