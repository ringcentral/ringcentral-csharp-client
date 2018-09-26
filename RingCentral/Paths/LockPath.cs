using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LockPath : PathSegment
    {
        internal LockPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "lock";
            }
        }
        // Locks a note with the specified ID providing the user with unique write access for 5 hours.
        public Task<GlipNoteInfo> Post()
        {
            return RC.Post<GlipNoteInfo>(Endpoint(true), null);
        }
    }
}
