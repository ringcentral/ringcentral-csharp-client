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
        // <p style='font-style:italic;'>Since 1.0.18 (Release 6.5)</p><p>Returns call recording metadata.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallRecording</td><td>Downloading call recording content</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<GetCallRecordingResponse> Get()
        {
            return RC.Get<GetCallRecordingResponse>(Endpoint(true), null);
        }
    }
}
