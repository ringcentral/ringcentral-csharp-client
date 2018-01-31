namespace RingCentral
{
    public partial class SIPInfoResponse
    {
        // User credentials
        public string @username { get; set; }
        // User password
        public string @password { get; set; }
        // Identifier for SIP authorization
        public string @authorizationId { get; set; }
        // SIP domain
        public string @domain { get; set; }
        // SIP outbound proxy
        public string @outboundProxy { get; set; }
        // Preferred transport. SIP info will be returned for this transport if supported
        public string @transport { get; set; }
        // For TLS transport only Base64 encoded certificate
        public string @certificate { get; set; }
    }
}
