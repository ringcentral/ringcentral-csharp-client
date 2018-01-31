namespace RingCentral
{
    public partial class MissedCallsInfo
    {
        // Email notification flag
        public bool? @notifyByEmail { get; set; }
        // SMS notification flag
        public bool? @notifyBySms { get; set; }
        // List of recipient email addresses for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] @advancedEmailAddresses { get; set; }
        // List of recipient phone numbers for missed call notifications. Returned if specified, in both modes (advanced/basic). Applied in advanced mode only
        public string[] @advancedSmsEmailAddresses { get; set; }
    }
}
