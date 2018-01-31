namespace RingCentral
{
    public partial class FederationExtensionInfo
    {
        // Internal identifier of an extension of current account
        public string @id { get; set; }
        // Number of an extension
        public string @extensionNumber { get; set; }
        // Extension user first name
        public string @firstName { get; set; }
        // Extension user last name
        public string @lastName { get; set; }
        // Conflicting extensions information
        public ConflictsInfo[] @conflicts { get; set; }
    }
}
