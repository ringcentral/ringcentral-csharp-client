namespace RingCentral
{
    public partial class GrantInfo
    {
        // Canonical URI of a grant
        public string @uri { get; set; }
        // Extension information
        public ExtensionInfoGrants @extension { get; set; }
        // Specifies if picking up of other extensions' calls is allowed for the extension. If 'Presence' feature is disabled for the given extension, the flag is not returned
        public bool? @callPickup { get; set; }
        // Specifies if monitoring of other extensions' calls is allowed for the extension. If 'CallMonitoring' feature is disabled for the given extension, the flag is not returned
        public bool? @callMonitoring { get; set; }
    }
}
