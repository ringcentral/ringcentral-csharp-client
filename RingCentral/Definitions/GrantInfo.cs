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
        // Specifies whether the current extension is able to make or receive calls on behalf of the user referenced in extension object
        public bool? @callOnBehalfOf { get; set; }
        // Specifies whether the current extension can delegate a call to the user referenced in extension object
        public bool? @callDelegation { get; set; }
    }
}
