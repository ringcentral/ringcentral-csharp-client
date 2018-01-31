namespace RingCentral
{
    public partial class ExtensionCreationRequest
    {
        // Contact Information
        public ContactInfoUpdateRequest @contact { get; set; }
        // Number of extension
        public string @extensionNumber { get; set; }
        // Password for extension. If not specified, the password is auto-generated
        public string @password { get; set; }
        // List of non-RC internal identifiers assigned to an extension
        public ReferenceInfo[] @references { get; set; }
        // Extension region data (timezone, home country, language)
        public RegionalSettings @regionalSettings { get; set; }
        // Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted' = ['NotStarted', 'Incomplete', 'Completed']
        public string @setupWizardState { get; set; }
        // Extension current state = ['Enabled', 'Disabled', 'NotActivated', 'Unassigned']
        public string @status { get; set; }
        // Status information (reason, comment). For 'Disabled' status only
        public ExtensionStatusInfo @statusInfo { get; set; }
        // Extension type = ['User', 'VirtualUser', 'DigitalUser', 'Department']
        public string @type { get; set; }
    }
}
