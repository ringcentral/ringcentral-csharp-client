namespace RingCentral
{
    public partial class AnsweringRuleInfo
    {
        // Canonical URI to the answering rule resource
        public string @uri { get; set; }
        // Internal identifier of an answering rule
        public string @id { get; set; }
        // Type of an answering rule
        public string @type { get; set; }
        // Name of an answering rule specified by user
        public string @name { get; set; }
        // Specifies if an answering rule is active or inactive
        public bool? @enabled { get; set; }
        // Schedule when an answering rule should be applied
        public ScheduleInfo @schedule { get; set; }
        // Answering rules are applied when calling to selected number(s)
        public CalledNumberInfo[] @calledNumbers { get; set; }
        // Answering rules are applied when calls are received from specified caller(s)
        public CallersInfo[] @callers { get; set; }
        // Specifies how incoming calls are forwarded
        public string @callHandlingAction { get; set; }
        // Forwarding parameters. Returned if 'ForwardCalls' is specified in 'callHandlingAction'. These settings determine the forwarding numbers to which the call will be forwarded
        public ForwardingInfo @forwarding { get; set; }
        // Unconditional forwarding parameters. Returned if 'UnconditionalForwarding' is specified in 'callHandlingAction'
        public UnconditionalForwardingInfo @unconditionalForwarding { get; set; }
        // Queue settings applied for department (call queue) extension type, with the 'AgentQueue' value specified as a call handling action
        public QueueInfo @queue { get; set; }
        // Transfer settings applied for department (call queue) extension type, with 'TransferToExtension' call handling action
        public TransferredExtensionInfo @transfer { get; set; }
        // Specifies whether to take a voicemail and who should do it
        public VoicemailInfo @voicemail { get; set; }
        // Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        public GreetingInfo[] @greetings { get; set; }
    }
}
