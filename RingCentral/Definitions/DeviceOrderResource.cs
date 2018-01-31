namespace RingCentral
{
    public partial class DeviceOrderResource
    {
        //
        public string @accountId { get; set; }
        //
        public string @requestNumber { get; set; }
        //
        public string @distributorName { get; set; }
        //
        public string @trackingNumber { get; set; }
        //
        public string @shippingCarrier { get; set; }
        //
        public DeviceInstance[] @devices { get; set; }
    }
}
