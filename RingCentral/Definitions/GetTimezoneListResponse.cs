namespace RingCentral
{
    public partial class GetTimezoneListResponse
    {
        // List of timezones
        public GetTimezoneInfoResponse[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
