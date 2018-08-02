using System.Threading.Tasks;
namespace RingCentral
{
    public partial class VoicemailPath : PathSegment
    {
        internal VoicemailPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "voicemail";
            }
        }
        // Sends a voicemail.
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
        // Sends a voicemail.
        public async Task<bool> Post(object parameters)
        {
            await RC.Post(Endpoint(true), parameters);
            return true;
        }
        // Sends a voicemail.
        public Task<bool> Post(CreateVoicemail parameters)
        {
            return Post(parameters as object);
        }
    }
}
