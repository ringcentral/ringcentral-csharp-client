namespace RingCentral
{
    public partial class GetDeviceInfoResponse
    {
        // Internal identifier of a device
        public string @id { get; set; }
        // Canonical URI of a device
        public string @uri { get; set; }
        // Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example 'HP-56-2-2'
        public string @sku { get; set; }
        // Device type. The default value is 'HardPhone'
        public string @type { get; set; }
        // Device name. Mandatory if ordering  SoftPhone  or  OtherPhone . Optional for  HardPhone . If not specified for HardPhone, then device  model  name is used as device  name
        public string @name { get; set; }
        // Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
        public string @serial { get; set; }
        // PC name for softphone
        public string @computerName { get; set; }
        // HardPhone model information
        public ModelInfo @model { get; set; }
        // This attribute can be omitted for unassigned devices
        public ExtensionInfo @extension { get; set; }
        // Address for emergency cases. The same emergency address is assigned to all the numbers of one device
        public EmergencyAddressInfo @emergencyServiceAddress { get; set; }
        // Phone lines information
        public PhoneLinesInfo @phoneLines { get; set; }
        // Shipping information, according to which devices (in case of  HardPhone ) or e911 stickers (in case of  SoftPhone  and  OtherPhone ) will be delivered to the customer
        public ShippingInfo @shipping { get; set; }
        // Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. EitherT? model  structure, or  boxBillingId  must be specified forT?HardPhone
        public long? @boxBillingId { get; set; }
    }
}
