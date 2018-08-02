namespace RingCentral
{
    public partial class GetCountryInfoConferencing
    {
        // Internal identifier of a country
        public string @id { get; set; }
        // Canonical URI of a country
        public string @uri { get; set; }
        // Country calling code defined by ITU-T recommendations [E.123](https://www.itu.int/rec/T-REC-E.123-200102-I/en) and [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I)
        public string @callingCode { get; set; }
        // Emergency calling feature availability/emergency address requirement indicator
        public bool? @emergencyCalling { get; set; }
        // Country code according to the ISO standard, see [ISO 3166](https://www.iso.org/iso-3166-country-codes.html)
        public string @isoCode { get; set; }
        // Official name of a country
        public string @name { get; set; }
    }
}
