namespace RingCentral
{
    public partial class AddressInfo
    {
        // User street address
        public string @streetAddress { get; set; }
        // User city
        public string @locality { get; set; }
        // User state/region
        public string @region { get; set; }
        // User postal code
        public string @postalCode { get; set; }
        // User country
        public string @country { get; set; }
        // Address type
        public string @type { get; set; }
    }
}
