namespace RingCentral
{
    public partial class CallMonitoringGroups
    {
        // Link to a call monitoring groups resource
        public string @uri { get; set; }
        // List of call monitoring group members
        public CallMonitoringGroupInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
