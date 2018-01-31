namespace RingCentral
{
    public partial class PagingOnlyGroupUsers
    {
        // List of users allowed to page this group
        public PagingGroupExtensionInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
