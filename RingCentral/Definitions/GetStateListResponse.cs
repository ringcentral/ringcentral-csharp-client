namespace RingCentral
{
    public partial class GetStateListResponse
    {
        // List of states
        public GetStateInfoResponse[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
