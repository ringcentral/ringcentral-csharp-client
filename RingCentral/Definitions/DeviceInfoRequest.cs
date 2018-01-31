namespace RingCentral
{
    public partial class DeviceInfoRequest
    {
        // Device unique identifier, retrieved on previous session (if any)
        public string @id { get; set; }
        // For iOS devices only Certificate name (used by iOS applications for APNS subscription)
        public string @appExternalId { get; set; }
        // For SoftPhone only Computer name
        public string @computerName { get; set; }
    }
}
