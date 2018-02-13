namespace RingCentral
{
    public partial class GlipAPNSInfo
    {
        // Apple Push Notification Service Info
        public APSInfo @type { get; set; }
        // Datetime of a call action in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // Universally unique identifier of a notification
        public string @uuid { get; set; }
        // Event filter URI
        public string @event { get; set; }
        // Internal identifier of a subscription
        public string @subscriptionId { get; set; }
        // Unread messages data
        public GlipUnreadMessageCountInfo @body { get; set; }
    }
}
