namespace RingCentral
{
    public partial class DeviceModelExtResource
    {
        // Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example 'HP-56-2-2'
        public string @sku { get; set; }
        // Device type. The default value is 'HardPhone'
        public string @type { get; set; }
        // HardPhone model information
        public DeviceModelResource @model { get; set; }
    }
}
