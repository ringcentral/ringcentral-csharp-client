namespace RingCentral
{
    public partial class CallerIdPhoneInfo
    {
        // Internal identifier of a phone number
        public string @id { get; set; }
        // Link to a phone number resource
        public string @uri { get; set; }
        // Phone number in E.164 (with '+' sign) format
        public string @phoneNumber { get; set; }
    }
}
