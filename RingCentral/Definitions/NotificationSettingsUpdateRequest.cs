namespace RingCentral
{
    public partial class NotificationSettingsUpdateRequest
    {
        // List of notification recipient email addresses
        public string[] @emailAddresses { get; set; }
        // List of notification recipient email addresses
        public string[] @smsEmailAddresses { get; set; }
        // Specifies notifications settings mode. If 'True' then advanced mode is on, it allows using different emails and/or phone numbers for each notification type. If 'False' then basic mode is on. Advanced mode settings are returned in both modes, if specified once, but if basic mode is switched on, they are not applied
        public bool? @advancedMode { get; set; }
        //
        public VoicemailsInfo @voicemails { get; set; }
        //
        public InboundFaxesInfo @inboundFaxes { get; set; }
        //
        public OutboundFaxesInfo @outboundFaxes { get; set; }
        //
        public InboundTextsInfo @inboundTexts { get; set; }
        //
        public MissedCallsInfo @missedCalls { get; set; }
    }
}
