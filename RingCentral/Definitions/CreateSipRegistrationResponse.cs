namespace RingCentral
{
    public partial class CreateSipRegistrationResponse
    {
        // SIP settings for device
        public SIPInfoResponse[] @sipInfo { get; set; }
        // SIP flags data
        public SIPFlagsRespones[] @sipFlags { get; set; }
    }
}
