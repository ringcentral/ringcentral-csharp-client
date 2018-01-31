namespace RingCentral
{
    public partial class CreateSubscriptionRequest
    {
        // Mandatory. Collection of URIs to API resources (see Event Types for details). For APNS transport type only message event filter is available
        public string[] @eventFilters { get; set; }
        // Notification delivery settings
        public NotificationDeliveryModeRequest @deliveryMode { get; set; }
        // Subscription lifetime in seconds. Max value is 7 days (604800 sec)
        public long? @expiresIn { get; set; }
    }
}
