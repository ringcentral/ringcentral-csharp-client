namespace RingCentral
{
    public partial class CallRecordingSettingsResource
    {
        //
        public OnDemandResource @onDemand { get; set; }
        //
        public AutomaticRecordingResource @automatic { get; set; }
        // Collection of Greeting Info
        public GreetingResource[] @greetings { get; set; }
    }
}
