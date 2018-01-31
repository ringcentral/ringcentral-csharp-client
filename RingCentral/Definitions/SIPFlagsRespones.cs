namespace RingCentral
{
    public partial class SIPFlagsRespones
    {
        // If 'True' VoIP calling feature is enabled
        public string @voipFeatureEnabled { get; set; }
        // If 'True' the request is sent from IP address of a country blocked for VoIP calling
        public string @voipCountryBlocked { get; set; }
        // If 'True' outbound calls are enabled
        public string @outboundCallsEnabled { get; set; }
    }
}
