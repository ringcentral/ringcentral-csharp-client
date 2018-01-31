namespace RingCentral
{
    public partial class PagingOnlyGroupDevices
    {
        // List of paging devices assigned to this group
        public PagingDeviceInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
