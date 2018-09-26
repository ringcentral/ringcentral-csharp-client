namespace RingCentral
{
    public partial class RuleInfo
    {
        // Forwarding number (or group) ordinal
        public long? @index { get; set; }
        // Number of rings for a forwarding number (or group)
        public long? @ringCount { get; set; }
        // Forwarding number status. Returned only if `showInactiveNumbers` is set to `true`
        public bool? @enabled { get; set; }
        // Forwarding number (or group) data
        public ForwardingNumberInfoRules[] @forwardingNumbers { get; set; }
    }
}
