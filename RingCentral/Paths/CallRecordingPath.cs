using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallRecordingPath : PathSegment
    {
        internal CallRecordingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "call-recording";
            }
        }
        public ExtensionsPath Extensions()
        {
            return new ExtensionsPath(this);
        }
        public BulkAssignPath BulkAssign()
        {
            return new BulkAssignPath(this);
        }
        public CustomGreetingsPath CustomGreetings(string _id)
        {
            return new CustomGreetingsPath(this, _id);
        }
        public CustomGreetingsPath CustomGreetings()
        {
            return new CustomGreetingsPath(this);
        }
        // Returns call recording settings.
        public Task<CallRecordingSettingsResource> Get()
        {
            return RC.Get<CallRecordingSettingsResource>(Endpoint(true), null);
        }
        // Updates current call recording settings
        public Task<CallRecordingSettingsResource> Put()
        {
            return RC.Put<CallRecordingSettingsResource>(Endpoint(true), null);
        }
        // Updates current call recording settings
        public Task<CallRecordingSettingsResource> Put(object parameters)
        {
            return RC.Put<CallRecordingSettingsResource>(Endpoint(true), parameters);
        }
        // Updates current call recording settings
        public Task<CallRecordingSettingsResource> Put(CallRecordingSettingsResource parameters)
        {
            return Put(parameters as object);
        }
    }
}
