namespace RingCentral
{
    public partial class VersionInfo
    {
        // Canonical URI of API versions
        public string @uri { get; set; }
        // Version of the RingCentral REST API
        public string @versionString { get; set; }
        // Release date of this version
        public string @releaseDate { get; set; }
        // URI part determining the current version
        public string @uriString { get; set; }
    }
}
