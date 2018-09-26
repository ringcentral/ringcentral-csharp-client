namespace RingCentral
{
    public partial class EmergencyAddressInfo
    {
        // Name of a customer
        public string @customerName { get; set; }
        // Street address, line 1 - street address, P.O. box, company name, c/o
        public string @street { get; set; }
        // Street address, line 2 - apartment, suite, unit, building, floor, etc.
        public string @street2 { get; set; }
        // City name
        public string @city { get; set; }
        // Zip code
        public string @zip { get; set; }
        // State/province name
        public string @state { get; set; }
        // Internal identifier of a state
        public string @stateId { get; set; }
        // ISO code of a state
        public string @stateIsoCode { get; set; }
        // Full name of a state
        public string @stateName { get; set; }
        // Internal identifier of a country
        public string @countryId { get; set; }
        // ISO code of a country
        public string @countryIsoCode { get; set; }
        // Country name
        public string @country { get; set; }
        // Full name of a country
        public string @countryName { get; set; }
    }
}
