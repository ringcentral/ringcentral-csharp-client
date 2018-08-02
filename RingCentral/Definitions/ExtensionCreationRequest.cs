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
        //
        public Roles[] @roles { get; set; }
        // Extension region data (timezone, home country, language)
        public RegionalSettings @regionalSettings { get; set; }
        // Specifies extension configuration wizard state (web service setup).
        public string @setupWizardState { get; set; }
        // Extension current state
        public string @status { get; set; }
        // Status information (reason, comment). For 'Disabled' status only
        public ExtensionStatusInfo @statusInfo { get; set; }
        // Extension type
        public string @type { get; set; }
        // Hides extension from showing in company directory. Supported for extensions of User type only. For unassigned extensions the value is set to 'True' by default. For assigned extensions the value is set to 'False' by default
        public bool? @hidden { get; set; }
    }
}
