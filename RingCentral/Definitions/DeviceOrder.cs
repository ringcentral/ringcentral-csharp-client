namespace RingCentral
{
    public partial class DeviceOrder
    {
        // Identifier of a device
        public string @id { get; set; }
        // Canonical URI of an order resource
        public string @uri { get; set; }
        // List of devices ordered
        public DeviceResource[] @devices { get; set; }
    }
}
