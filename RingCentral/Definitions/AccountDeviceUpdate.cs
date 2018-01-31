namespace RingCentral
{
    public partial class AccountDeviceUpdate
    {
        // Address for emergency cases. The same emergency address is assigned to all numbers of a single device
        public EmergencyAddressInfoRequest @emergencyServiceAddress { get; set; }
    }
}
