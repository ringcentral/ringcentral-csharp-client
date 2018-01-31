namespace RingCentral
{
    public partial class LicenseTypes
    {
        // Canonical URI of a license types resource
        public string @uri { get; set; }
        // List of supported licenses
        public LicenseInfo[] @records { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
    }
}
