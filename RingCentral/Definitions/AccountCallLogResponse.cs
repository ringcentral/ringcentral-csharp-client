namespace RingCentral
{
    public partial class AccountCallLogResponse
    {
        // List of call log records
        public CallLogRecord[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
