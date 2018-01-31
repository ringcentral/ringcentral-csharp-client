namespace RingCentral
{
    public partial class GetMessageList
    {
        // List of records with message information
        public GetMessageInfoResponse[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
