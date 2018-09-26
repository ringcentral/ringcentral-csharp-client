using System.Threading.Tasks;
namespace RingCentral
{
    public partial class UnlockPath : PathSegment
    {
        internal UnlockPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "unlock";
            }
        }
        // Unlocks a note with the specified ID. For letting other users edit the note the user should unlock it. Notes that are locked by other users cannot be unlocked until 5 hours pass since the lock datetime
        public Task<GlipNoteInfo> Post()
        {
            return RC.Post<GlipNoteInfo>(Endpoint(true), null);
        }
    }
}
