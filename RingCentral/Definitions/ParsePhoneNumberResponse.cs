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
        // One of the numbers to be parsed, passed as a string in response
        public string @originalString { get; set; }
        // Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details
        public string @areaCode { get; set; }
        // Domestic format of a phone number
        public string @formattedNational { get; set; }
        // International format of a phone number
        public string @formattedInternational { get; set; }
        // Dialing format of a phone number
        public string @dialable { get; set; }
        // E.164 (11-digits) format of a phone number
        public string @e164 { get; set; }
        //  True  if the number is in a special format (for example N11 code)
        public bool? @special { get; set; }
        // E.164 (11-digits) format of a phone number without the plus sign ('+')
        public string @normalized { get; set; }
        // Information on a country the phone number belongs to
        public GetCountryInfoNumberParser[] @country { get; set; }
    }
}
