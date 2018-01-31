namespace RingCentral
{
    public partial class BrandInfo
    {
        // Internal identifier of a brand
        public string @id { get; set; }
        // Brand name, for example  RingCentral UK ,  ClearFax
        public string @name { get; set; }
        // Home country information
        public CountryInfo @homeCountry { get; set; }
    }
}
