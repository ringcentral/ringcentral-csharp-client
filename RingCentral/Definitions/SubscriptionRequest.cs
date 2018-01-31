namespace RingCentral
{
    public partial class SubscriptionRequest
    {
        //
        public string[] @eventFilters { get; set; }
        //
        public DeliveryModeResource @deliveryMode { get; set; }
        //
        public long? @expiresIn { get; set; }
    }
}
