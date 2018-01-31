namespace RingCentral
{
    public partial class AdbPresenceInfoResource
    {
        //
        public string @accountId { get; set; }
        //
        public string @extensionId { get; set; }
        //
        public string @extensionType { get; set; }
        //
        public string @extensionStatus { get; set; }
        //
        public string @dndStatus { get; set; }
        //
        public string @userStatus { get; set; }
        //
        public string @message { get; set; }
        //
        public string @agentStatus { get; set; }
        //
        public string @extensionNumber { get; set; }
        //
        public bool? @allowSeeMyPresence { get; set; }
        //
        public bool? @ringOnMonitoredCall { get; set; }
        //
        public bool? @pickUpCallsOnHold { get; set; }
        //
        public bool? @presenceFeatureAvailable { get; set; }
        //
        public bool? @dndFeatureAvailable { get; set; }
    }
}
