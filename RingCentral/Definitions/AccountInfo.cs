namespace RingCentral
{
    public partial class AccountInfo
    {
        // Internal identifier of an account
        public string @id { get; set; }
        // Canonical URI of an account
        public string @uri { get; set; }
        // Main phone number of the current account
        public string @mainNumber { get; set; }
        // Operator's extension information. This extension will receive all calls and messages intended for the operator
        public ExtensionInfo @operator { get; set; }
        // Additional account identifier, developed and applied by the client
        public string @partnerId { get; set; }
        // Account service information, including brand, service plan and billing plan
        public Account_ServiceInfo @serviceInfo { get; set; }
        // Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'
        public string @setupWizardState { get; set; }
        // Status of the current account
        public string @status { get; set; }
        // Status information (reason, comment, lifetime). Returned for 'Disabled' status only
        public StatusInfo @statusInfo { get; set; }
    }
}
