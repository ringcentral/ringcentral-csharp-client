namespace RingCentral
{
    public partial class AnsweringRuleResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @type { get; set; }
        //
        public string @name { get; set; }
        //
        public bool? @enabled { get; set; }
        //
        public ScheduleResource @schedule { get; set; }
        //
        public CallerResource[] @callers { get; set; }
        //
        public PhoneNumberResource[] @calledNumbers { get; set; }
        //
        public string @callHandlingAction { get; set; }
        //
        public AnsweringForwardingResource @forwarding { get; set; }
        //
        public UnconditionalForwardingResource @unconditionalForwarding { get; set; }
        //
        public VoicemailSettingsResource @voicemail { get; set; }
    }
}
