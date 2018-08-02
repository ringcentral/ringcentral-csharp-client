namespace RingCentral
{
    public partial class CreateForwardingNumberRequest
    {
        // Forwarding/Call flip phone number
        public string @phoneNumber { get; set; }
        // Forwarding/Call flip number title
        public string @label { get; set; }
        // Forwarding/Call flip phone type. If specified, 'label' attribute value is ignored. The default value is 'Other'
        public string @type { get; set; }
        // Reference to the other extension device. Applicable for 'PhoneLine' type only. Cannot be specified together with 'phoneNumber' parameter.
        public CreateForwardingNumberDeviceInfo @device { get; set; }
    }
}
