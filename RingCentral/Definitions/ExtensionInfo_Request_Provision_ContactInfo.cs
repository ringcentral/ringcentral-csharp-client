namespace RingCentral
{
    public partial class ExtensionInfo_Request_Provision_ContactInfo
    {
        // Mandatory. Extension user first name
        public string @firstName { get; set; }
        // Mandatory. Extension user last name
        public string @lastName { get; set; }
        // Mandatory. Extension user contact email
        public string @email { get; set; }
    }
}
