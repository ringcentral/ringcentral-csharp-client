namespace RingCentral
{
    public partial class CallMonitoringGroupMemberList
    {
        // Link to a call monitoring group members resource
        public string @uri { get; set; }
        // List of a call monitoring group members
        public CallMonitoringGroupMemberInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
