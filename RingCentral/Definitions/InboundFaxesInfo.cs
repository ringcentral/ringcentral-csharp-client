namespace RingCentral
{
    public partial class InboundFaxesInfo
    {
        // Email notification flag
        public bool? @notifyByEmail { get; set; }
        // SMS notification flag
        public bool? @notifyBySms { get; set; }
        // List of recipient email addresses for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] @advancedEmailAddresses { get; set; }
        // List of recipient phone numbers for inbound fax notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] @advancedSmsEmailAddresses { get; set; }
        // Indicates whether fax should be attached to email
        public bool? @includeAttachment { get; set; }
        // Indicates whether email should be automatically marked as read
        public bool? @markAsRead { get; set; }
    }
}
