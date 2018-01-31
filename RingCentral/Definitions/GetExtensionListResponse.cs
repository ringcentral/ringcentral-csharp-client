namespace RingCentral
{
    public partial class GetExtensionListResponse
    {
        // List of extensions with extension information
        public GetExtensionInfoResponse[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
