namespace RingCentral
{
    public partial class CallQueues
    {
        // Link to a call queues resource
        public string @uri { get; set; }
        // List of call queues
        public CallQueueInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
