namespace RingCentral
{
    public partial class BlockedNumbersList
    {
        // List of blocked phone numbers
        public BlockedNumberInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
