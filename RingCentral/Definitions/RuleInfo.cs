namespace RingCentral
{
    public partial class RuleInfo
    {
        // Forwarding number (or group) ordinal
        public long? @index { get; set; }
        // Number of rings for a forwarding number (or group)
        public long? @ringCount { get; set; }
        // Forwarding number (or group) data
        public RuleInfo_ForwardingNumberInfo[] @forwardingNumbers { get; set; }
    }
}
