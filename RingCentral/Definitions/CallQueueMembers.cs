namespace RingCentral
{
    public partial class CallQueueMembers
    {
        // Link to a call queue members resource
        public string @uri { get; set; }
        // List of call queue members
        public CallQueueMemberInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
