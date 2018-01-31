namespace RingCentral
{
    public partial class GetExtensionGrantListResponse
    {
        // List of extension grants with the data
        public GrantInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
