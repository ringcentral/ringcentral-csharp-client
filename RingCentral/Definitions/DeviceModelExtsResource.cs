namespace RingCentral
{
    public partial class DeviceModelExtsResource
    {
        // Canonical URI of a device
        public string @uri { get; set; }
        // Devices data
        public DeviceModelExtResource[] @records { get; set; }
    }
}
