namespace RingCentral
{
    public partial class GetMonitoredExtensionsResponse
    {
        // Canonical URI of the monitored lines (extensions) resource
        public string @uri { get; set; }
        // List of lines (extensions) the presence of which is monitored by the user. The first two lines always indicate the user's extension presence, they cannot be changed
        public LineInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
