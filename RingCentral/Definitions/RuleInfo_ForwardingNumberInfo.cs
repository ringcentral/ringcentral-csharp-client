namespace RingCentral
{
    public partial class RuleInfo_ForwardingNumberInfo
    {
        // Link to a forwarding number resource
        public string @uri { get; set; }
        // Internal identifier of a forwarding number
        public string @id { get; set; }
        // Phone number to which the call is forwarded
        public string @phoneNumber { get; set; }
        // Title of a forwarding number
        public string @label { get; set; }
    }
}
