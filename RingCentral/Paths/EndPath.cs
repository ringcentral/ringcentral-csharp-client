using System.Threading.Tasks;
namespace RingCentral
{
    public partial class EndPath : PathSegment
    {
        internal EndPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "end";
            }
        }
        // Ends a meetings which is in progress.
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
    }
}
