namespace RingCentral
{
    public partial class AccountPresenceInfo
    {
        // Canonical URI of account presence resource
        public string @uri { get; set; }
        // List of Prompts
        public GetPresenceInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
