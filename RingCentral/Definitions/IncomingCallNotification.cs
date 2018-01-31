namespace RingCentral
{
    public partial class IncomingCallNotification
    {
        // Event filter URI
        public string @event { get; set; }
        // Universally unique identifier of a notification
        public string @uuid { get; set; }
        // Internal identifier of a subscription
        public string @subscriptionId { get; set; }
        // The datetime of a call action in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @timestamp { get; set; }
        // Internal identifier of an extension
        public string @extensionId { get; set; }
        // Calling action, for example 'StartRing'
        public string @action { get; set; }
        // Identifier of a call session
        public string @sessionId { get; set; }
        // Identifier of a server
        public string @serverId { get; set; }
        // Phone number of a caller
        public string @from { get; set; }
        // Caller name
        public string @fromName { get; set; }
        // Phone number of a callee
        public string @to { get; set; }
        // Callee name
        public string @toName { get; set; }
        // Unique identifier of a session
        public string @sid { get; set; }
        // SIP proxy registration name
        public string @toUrl { get; set; }
        // User data
        public string @srvLvl { get; set; }
        // User data
        public string @srvLvlExt { get; set; }
        // File containing recorded caller name
        public string @recUrl { get; set; }
    }
}
