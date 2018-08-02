namespace RingCentral
{
    public partial class AccountDeviceUpdate
    {
        // Address for emergency cases. The same emergency address is assigned to all numbers of a single device
        public EmergencyAddressInfoRequest @emergencyServiceAddress { get; set; }
        // Information on extension that the device is assigned to
        public DeviceUpdateExtensionInfo @extension { get; set; }
        // Information on phone lines added to a device
        public DeviceUpdatePhoneLinesInfo @phoneLines { get; set; }
    }
}
