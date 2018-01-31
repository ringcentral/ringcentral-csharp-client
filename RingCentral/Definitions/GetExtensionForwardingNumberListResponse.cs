namespace RingCentral
{
    public partial class GetExtensionForwardingNumberListResponse
    {
        // List of forwarding phone numbers
        public ForwardingNumberInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
