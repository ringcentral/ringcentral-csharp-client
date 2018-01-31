namespace RingCentral
{
    public partial class FaxCountryInfo
    {
        // Internal identifier of a home country
        public string @id { get; set; }
        // Country code in ISO 3166-1 alpha-2. If specified then country ID cannot be specified
        public string @isoCode { get; set; }
    }
}
