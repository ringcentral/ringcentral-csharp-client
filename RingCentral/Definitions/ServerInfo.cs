namespace RingCentral
{
    public partial class ServerInfo
    {
        // Canonical URI of the API version
        public string @uri { get; set; }
        // Full API version information: uri, number, release date
        public VersionInfo[] @apiVersions { get; set; }
        // Server version
        public string @serverVersion { get; set; }
        // Server revision
        public string @serverRevision { get; set; }
    }
}
