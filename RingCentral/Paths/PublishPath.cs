using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PublishPath : PathSegment
    {
        internal PublishPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "publish";
            }
        }
        // Publishs a note to make it visible to others
        public Task<GlipNoteInfo> Post()
        {
            return RC.Post<GlipNoteInfo>(Endpoint(true), null);
        }
    }
}
