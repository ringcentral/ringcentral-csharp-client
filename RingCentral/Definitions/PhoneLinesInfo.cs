namespace RingCentral
{
    public partial class PhoneLinesInfo
    {
        // Type of phone line
        public string @lineType { get; set; }
        // Phone number information
        public PhoneLinesInfo_PhoneNumberInfo @phoneInfo { get; set; }
    }
}
