namespace RingCentral
{
    public partial class ParsePhoneNumberResponse
    {
        // Canonical URI of a resource
        public string @uri { get; set; }
        // Information on a user home country
        public GetCountryInfoNumberParser[] @homeCountry { get; set; }
        // Parsed phone numbers data
        public PhoneNumberInfoNumberParser[] @phoneNumbers { get; set; }
    }
}
