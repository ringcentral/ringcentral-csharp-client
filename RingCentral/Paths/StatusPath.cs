using System.Threading.Tasks;
namespace RingCentral
{
    public partial class StatusPath : PathSegment
    {
        internal StatusPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "status";
            }
        }
        // Returns current PAS service status.
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
    }
}
