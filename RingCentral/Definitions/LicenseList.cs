namespace RingCentral
{
    public partial class LicenseList
    {
        // List of licenses
        public LicenseInfo[] @records { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
    }
}
