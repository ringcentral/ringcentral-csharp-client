namespace RingCentral
{
    public partial class EmergencyAddressInfoRequest
    {
        // Name of a customer
        public string @customerName { get; set; }
        // Street address, line 1 - street address, P.O. box, company name, c/o
        public string @street { get; set; }
        // Street address, line 2 - apartment, suite, unit, building, floor, etc
        public string @street2 { get; set; }
        // City name
        public string @city { get; set; }
        // State/province name
        public string @state { get; set; }
        // Zip code
        public string @zip { get; set; }
        // Country name
        public string @country { get; set; }
    }
}
