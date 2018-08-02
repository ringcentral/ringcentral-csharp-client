namespace RingCentral
{
    public partial class RuleInfoCreateRuleRequest
    {
        // Forwarding number (or group) ordinal. Not returned for inactive numbers
        public long? @index { get; set; }
        // Number of rings for a forwarding number (or group). For inactive numbers the default value ('4') is returned
        public long? @ringCount { get; set; }
        // Phone number status. Returned only if `showInactiveNumbers` is set to `true`
        public bool? @enabled { get; set; }
        // Forwarding number (or group) data
        public ForwardingNumberInfoRulesCreateRuleRequest[] @forwardingNumbers { get; set; }
    }
}
