namespace RingCentral
{
    public partial class QueueInfo
    {
        // Specifies how calls are transferred to group members
        public string @transferMode { get; set; }
        // Information on a call forwarding rule
        public FixedOrderAgents[] @fixedOrderAgents { get; set; }
        // Connecting audio interruption mode
        public string @holdAudioInterruptionMode { get; set; }
        // Connecting audio interruption message period in seconds
        public long? @holdAudioInterruptionPeriod { get; set; }
        // Maximum time in seconds to wait for a call queue member before trying the next member
        public long? @agentTimeout { get; set; }
        // Minimum post-call wrap up time in seconds before agent status is automatically set
        public long? @wrapUpTime { get; set; }
        // Maximum hold time in seconds to wait for an available call queue member
        public long? @holdTime { get; set; }
        // Maximum count of callers on hold
        public long? @maxCallers { get; set; }
        // Action which should be taken if count of callers on hold exceeds the maximum
        public string @maxCallersAction { get; set; }
    }
}
