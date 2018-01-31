namespace RingCentral
{
    public partial class BrandResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @name { get; set; }
        //
        public CountryResource @homeCountry { get; set; }
        //
        public Currency @currency { get; set; }
    }
}
