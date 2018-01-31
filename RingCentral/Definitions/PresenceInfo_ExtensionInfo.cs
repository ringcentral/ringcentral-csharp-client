namespace RingCentral
{
    public partial class PresenceInfo_ExtensionInfo
    {
        // Internal identifier of an extension
        public string @id { get; set; }
        // Canonical URI of an extension
        public string @uri { get; set; }
        // Extension number (usually 3 or 4 digits)
        public string @extensionNumber { get; set; }
    }
}
