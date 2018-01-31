namespace RingCentral
{
    public partial class CreateSipRegistrationRequest
    {
        // Device unique description
        public DeviceInfoRequest[] @device { get; set; }
        // SIP settings for device
        public SIPInfoRequest[] @sipInfo { get; set; }
    }
}
