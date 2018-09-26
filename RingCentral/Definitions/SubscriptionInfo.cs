namespace RingCentral
{
    public partial class SubscriptionInfo
    {
        // Internal identifier of a subscription
        public string @id { get; set; }
        // Canonical URI of a subscription
        public string @uri { get; set; }
        // Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is subscribed to
        public string[] @eventFilters { get; set; }
        // Collection of API resources (message-store/presence/detailed presence) corresponding to events the user is not subscribed to due to certain limitations
        public DisabledFilterInfo[] @disabledFilters { get; set; }
        // Subscription expiration datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @expirationTime { get; set; }
        // Subscription lifetime in seconds
        public long? @expiresIn { get; set; }
        // Subscription status
        public string @status { get; set; }
        // Subscription creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // Delivery mode data
        public NotificationDeliveryMode @deliveryMode { get; set; }
        //
        public NotificationBlacklistedData @blacklistedData { get; set; }
    }
}
