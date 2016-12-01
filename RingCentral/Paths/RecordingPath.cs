using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RecordingPath : Model
    {
        internal RecordingPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
        // Get Call Recording Metadata
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of the call recording
            public string @id { get; set; }
            // Link to the call recording binary content
            public string @contentUri { get; set; }
            // Call recording file format. Supported format is audio/x-wav
            public string @contentType { get; set; }
            // Recorded call duration
            public long? @duration { get; set; }
        }
    }
}
