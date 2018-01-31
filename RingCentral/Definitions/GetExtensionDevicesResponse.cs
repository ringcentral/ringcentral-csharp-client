namespace RingCentral
{
    public partial class GetExtensionDevicesResponse
    {
        // List of extension devices
        public GetDeviceInfoResponse[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
