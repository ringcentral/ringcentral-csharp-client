namespace RingCentral
{
    public partial class ExtensionInfo_Request_Provision
    {
        // Mandatory. Resulting extension status
        public string @status { get; set; }
        // Mandatory. Extension user contact information
        public ExtensionInfo_Request_Provision_ContactInfo @contact { get; set; }
    }
}
