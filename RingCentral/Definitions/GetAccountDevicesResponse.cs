namespace RingCentral
{
    public partial class GetAccountDevicesResponse
    {
        // List of extension records
        public GetDeviceInfoResponse[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
