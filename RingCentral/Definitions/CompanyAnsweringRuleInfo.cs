namespace RingCentral
{
    public partial class CompanyAnsweringRuleInfo
    {
        // Internal identifier of an answering rule
        public string @id { get; set; }
        // Canonical URI of an answering rule
        public string @uri { get; set; }
        // Specifies if the rule is active or inactive. The default value is 'True'
        public bool? @enabled { get; set; }
        // Type of an answering rule
        public string @type { get; set; }
        // Name of an answering rule specified by user. Max number of symbols is 30. The default value is 'My Rule N' where 'N' is the first free number
        public string @name { get; set; }
        // Answering rule will be applied when calls are received from the specified caller(s)
        public CompanyAnsweringRuleCallersInfoRequest[] @callers { get; set; }
        // Answering rule will be applied when calling the specified number(s)
        public CompanyAnsweringRuleCalledNumberInfoRequest[] @calledNumbers { get; set; }
        // Schedule when an answering rule should be applied ,
        public CompanyAnsweringRuleScheduleInfo @schedule { get; set; }
        // Specifies how incoming calls are forwarded. The default value is 'Operator' 'Operator' - play company greeting and forward to operator extension 'Disconnect' - play company greeting and disconnect 'Bypass' - bypass greeting to go to selected extension = ['Operator', 'Disconnect', 'Bypass']
        public string @callHandlingAction { get; set; }
        // Extension to which the call is forwarded in 'Bypass' mode
        public CompanyAnsweringRuleCallersInfoRequest @extension { get; set; }
        // Greetings applied for an answering rule; only predefined greetings can be applied, see Dictionary Greeting List
        public GreetingInfo[] @greetings { get; set; }
    }
}
