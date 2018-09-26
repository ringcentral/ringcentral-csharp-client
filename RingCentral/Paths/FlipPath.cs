using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FlipPath : PathSegment
    {
        internal FlipPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "flip";
            }
        }
        // Performs call flip procedure by holding opposite party and calling to the specified target
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
        // Performs call flip procedure by holding opposite party and calling to the specified target
        public async Task<bool> Post(object parameters)
        {
            await RC.Post(Endpoint(true), parameters);
            return true;
        }
        // Performs call flip procedure by holding opposite party and calling to the specified target
        public Task<bool> Post(CallPartyFlip parameters)
        {
            return Post(parameters as object);
        }
    }
}
