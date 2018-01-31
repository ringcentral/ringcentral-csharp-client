namespace RingCentral
{
    public partial class DepartmentMemberList
    {
        // List of department members extensions
        public ExtensionInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
