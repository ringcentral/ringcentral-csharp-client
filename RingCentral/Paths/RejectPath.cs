using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RejectPath : PathSegment
    {
        internal RejectPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "reject";
            }
        }
        // Rejects an inbound call in a "Setup" or "Proceeding" state
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
    }
}
