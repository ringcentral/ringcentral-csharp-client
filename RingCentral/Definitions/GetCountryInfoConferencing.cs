namespace RingCentral
{
    public partial class GetCountryInfoConferencing
    {
        // Internal identifier of a country
        public string @id { get; set; }
        // Canonical URI of a country
        public string @uri { get; set; }
        // Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
        public string @callingCode { get; set; }
        // Emergency calling feature availability/emergency address requirement indicator
        public bool? @emergencyCalling { get; set; }
        // Country code according to the ISO standard, see ISO 3166
        public string @isoCode { get; set; }
        // Official name of a country
        public string @name { get; set; }
    }
}
