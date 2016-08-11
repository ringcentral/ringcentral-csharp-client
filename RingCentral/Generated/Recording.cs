
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Recording : Model
    {
        internal Recording(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "recording";
            }
        }
        public Content Content(ID _id)
        {
            return new Content(this, _id);
        }
        public Content Content()
        {
            return new Content(this, null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of the call recording
            public long? id { get; set; }
            // Link to the call recording binary content
            public string contentUri { get; set; }
            // Call recording file format. Supported format is audio/x-wav
            public string contentType { get; set; }
            // Recorded call duration
            public long? duration { get; set; }
        }
    }
}
