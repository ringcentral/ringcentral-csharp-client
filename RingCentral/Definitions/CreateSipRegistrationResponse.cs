namespace RingCentral
{
    public partial class CreateSipRegistrationResponse
    {
        // Suggested interval in seconds to periodically call SIP-provision API and update the local cache
        public long? @pollingInterval { get; set; }
        //
        public string[] @sipErrorCodes { get; set; }
        // SIP settings for device
        public SIPInfoResponse[] @sipInfo { get; set; }
        // SIP flags data
        public SIPFlagsResponse[] @sipFlags { get; set; }
    }
}
