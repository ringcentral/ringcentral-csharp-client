namespace RingCentral
{
    public partial class OutboundFaxesInfo
    {
        // Email notification flag
        public bool? @notifyByEmail { get; set; }
        // SMS notification flag
        public bool? @notifyBySms { get; set; }
        // List of recipient email addresses for outbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] @advancedEmailAddresses { get; set; }
        // List of recipient phone numbers for outbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] @advancedSmsEmailAddresses { get; set; }
    }
}
