namespace RingCentral
{
    public partial class SubscriptionResponse
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @creationTime { get; set; }
        //
        public string @status { get; set; }
        //
        public string[] @eventFilters { get; set; }
        //
        public string @expirationTime { get; set; }
        //
        public long? @expiresIn { get; set; }
        //
        public DeliveryModeResource @deliveryMode { get; set; }
    }
}
