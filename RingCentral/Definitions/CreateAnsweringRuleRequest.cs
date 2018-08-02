namespace RingCentral
{
    public partial class CreateAnsweringRuleRequest
    {
        // Specifies if the rule is active or inactive. The default value is 'True'
        public bool? @enabled { get; set; }
        // Type of an answering rule. The 'Custom' value should be specified
        public string @type { get; set; }
        // Name of an answering rule specified by user
        public string @name { get; set; }
        // Answering rule will be applied when calls are received from the specified caller(s)
        public CallersInfoRequest[] @callers { get; set; }
        // Answering rules are applied when calling to selected number(s)
        public CalledNumberInfo[] @calledNumbers { get; set; }
        // Schedule when an answering rule should be applied
        public ScheduleInfo @schedule { get; set; }
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
        // Call screening status. 'Off' - no call screening; 'NoCallerId' - if caller ID is missing, then callers are asked to say their name before connecting; 'UnknownCallerId' - if caller ID is not in contact list, then callers are asked to say their name before connecting; 'Always' - the callers are always asked to say their name before connecting. The default value is 'Off'
        public string @screening { get; set; }
    }
}
