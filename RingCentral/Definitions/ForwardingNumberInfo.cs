namespace RingCentral
{
    public partial class ForwardingNumberInfo
    {
        // Internal identifier of a forwarding/call flip phone number
        public string @id { get; set; }
        // Canonical URI of a forwarding/call flip phone number
        public string @uri { get; set; }
        // Forwarding/Call flip phone number
        public string @phoneNumber { get; set; }
        // Forwarding/Call flip number title
        public string @label { get; set; }
        // Type of option this phone number is used for. Multiple values are accepted
        public string @features { get; set; }
        // Number assigned to the call flip phone number, corresponds to the shortcut dial number
        public long? @flipNumber { get; set; }
    }
}
