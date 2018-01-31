namespace RingCentral
{
    public partial class ParkLocationResponse
    {
        // List of user extensions allowed to park and unpark calls to/from the extension specified
        public ExtensionInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
