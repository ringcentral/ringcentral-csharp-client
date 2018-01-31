namespace RingCentral
{
    public partial class GetCountryListResponse
    {
        // List of countries with the country data
        public GetCountryInfoDictionaryResponse[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
