namespace RingCentral
{
    public partial class CallQueueInfoRequest
    {
        // Target percentage of calls that must be answered by agents within the service level time threshold
        public long? @slaGoal { get; set; }
        //
        public long? @slaThresholdSeconds { get; set; }
        //
        public bool? @includeAbandonedCalls { get; set; }
        //
        public long? @abandonedThresholdSeconds { get; set; }
    }
}
