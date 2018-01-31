namespace RingCentral
{
    public partial class SubscriptionInfo
    {
        // Internal identifier of a subscription
        public string @id { get; set; }
        // Canonical URI of a subscription
        public string @uri { get; set; }
        // Collection of URIs to API resources (message-store/presence/detailed presence)
        public string[] @eventFilters { get; set; }
        // Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @expirationTime { get; set; }
        // Subscription lifetime in seconds. The default value is 900
        public long? @expiresIn { get; set; }
        // Subscription status
        public string @status { get; set; }
        // Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // Delivery mode data
        public NotificationDeliveryMode @deliveryMode { get; set; }
    }
}
