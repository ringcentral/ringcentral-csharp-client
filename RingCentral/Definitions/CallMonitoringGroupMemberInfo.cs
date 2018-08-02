namespace RingCentral
{
    public partial class CallMonitoringGroupMemberInfo
    {
        // Link to a call monitoring group member
        public string @uri { get; set; }
        // Internal identifier of a call monitoring group member
        public string @id { get; set; }
        // Extension number of a call monitoring group member
        public string @extensionNumber { get; set; }
        // Call monitoring permission; mltiple values allowed: * "Monitoring" - User can monitor a group * "Monitored" - User can be monitored
        public string @permissions { get; set; }
    }
}
