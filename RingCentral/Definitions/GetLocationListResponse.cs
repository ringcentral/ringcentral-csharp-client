namespace RingCentral
{
    public partial class GetLocationListResponse
    {
        // List of locations
        public LocationInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
