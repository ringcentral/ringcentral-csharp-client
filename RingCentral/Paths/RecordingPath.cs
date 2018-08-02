using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RecordingPath : PathSegment
    {
        internal RecordingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "recording";
            }
        }
        public ContentPath Content(string _id)
        {
            return new ContentPath(this, _id);
        }
        public ContentPath Content()
        {
            return new ContentPath(this);
        }
        // Returns call recording metadata by ID.
        public Task<GetCallRecordingResponse> Get()
        {
            return RC.Get<GetCallRecordingResponse>(Endpoint(true), null);
        }
    }
}
