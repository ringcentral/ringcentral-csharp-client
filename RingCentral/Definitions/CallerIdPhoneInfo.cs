namespace RingCentral
{
    public partial class CallerIdPhoneInfo
    {
        // Internal identifier of a phone number
        public string @id { get; set; }
        // Link to a phone number resource
        public string @uri { get; set; }
        // Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) (with '+' sign) format
        public string @phoneNumber { get; set; }
    }
}
