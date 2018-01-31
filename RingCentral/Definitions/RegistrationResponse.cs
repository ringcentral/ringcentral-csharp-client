namespace RingCentral
{
    public partial class RegistrationResponse
    {
        //
        public string @uri { get; set; }
        //
        public DeviceResource @device { get; set; }
        //
        public SipInfo[] @sipInfo { get; set; }
        //
        public SipFlags @sipFlags { get; set; }
    }
}
