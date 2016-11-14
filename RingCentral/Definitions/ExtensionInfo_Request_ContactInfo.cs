namespace RingCentral
{
    public partial class ExtensionInfo_Request_ContactInfo
    {
        // Contact information
        public ContactInfo @contact { get; set; }
        // Region data (timezone, home country, language)
        public ExtensionInfo_Request_ContactInfo_RegionalSettings @regionalSettings { get; set; }
        // Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
        public string @setupWizardState { get; set; }
        // Extension user department
        public string @department { get; set; }
    }
}
