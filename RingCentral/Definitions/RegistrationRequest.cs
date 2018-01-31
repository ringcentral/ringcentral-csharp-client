namespace RingCentral
{
    public partial class RegistrationRequest
    {
        //
        public DeviceToRegister @device { get; set; }
        //
        public SipDetailsToRegister[] @sipInfo { get; set; }
    }
}
