namespace RingCentral
{
    public partial class EmergencyServiceAddressResource
    {
        //
        public string @street { get; set; }
        //
        public string @street2 { get; set; }
        //
        public string @city { get; set; }
        //
        public string @zip { get; set; }
        //
        public string @customerName { get; set; }
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
