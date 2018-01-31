namespace RingCentral
{
    public partial class ExtensionInfoGrants
    {
        // Internal identifier of an extension
        public string @id { get; set; }
        // Canonical URI of an extension
        public string @uri { get; set; }
        // Extension short number (usually 3 or 4 digits)
        public string @extensionNumber { get; set; }
        // Extension type
        public string @type { get; set; }
    }
}
