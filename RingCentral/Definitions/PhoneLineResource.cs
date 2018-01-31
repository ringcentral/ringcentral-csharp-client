namespace RingCentral
{
    public partial class PhoneLineResource
    {
        //
        public string @lineType { get; set; }
        //
        public PhoneNumberResource @phoneInfo { get; set; }
        //
        public EmergencyAddress @emergencyAddress { get; set; }
    }
}
