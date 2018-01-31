namespace RingCentral
{
    public partial class UpdateForwardingNumberRequest
    {
        // Forwarding/Call flip phone number
        public string @phoneNumber { get; set; }
        // Forwarding/Call flip number title
        public string @label { get; set; }
        // Number assigned to the call flip phone number, corresponds to the shortcut dial number
        public string @flipNumber { get; set; }
    }
}
