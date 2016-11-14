namespace RingCentral
{
    public partial class DialInNumbers
    {
        // Phone number of the dial-in number for the meeting in e.164 format
        public string @phoneNumber { get; set; }
        // Phone number of the dial-in number formatted according to the extension home country
        public string @formattedNumber { get; set; }
        // Optional field in case the dial-in number is associated with a particular location
        public string @location { get; set; }
        // Country resource corresponding to the dial-in number
        public DialInNumbers_CountryInfo @country { get; set; }
    }
}
