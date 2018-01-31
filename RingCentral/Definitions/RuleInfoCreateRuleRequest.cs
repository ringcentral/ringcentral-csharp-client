namespace RingCentral
{
    public partial class RuleInfoCreateRuleRequest
    {
        // Forwarding number (or group) ordinal
        public long? @index { get; set; }
        // Number of rings for a forwarding number (or group)
        public long? @ringCount { get; set; }
        // Forwarding number (or group) data
        public ForwardingNumberInfoRulesCreateRuleRequest[] @forwardingNumbers { get; set; }
    }
}
