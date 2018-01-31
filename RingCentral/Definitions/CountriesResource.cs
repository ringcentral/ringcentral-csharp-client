namespace RingCentral
{
    public partial class CountriesResource
    {
        //
        public string @uri { get; set; }
        //
        public CountryResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
