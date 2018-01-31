namespace RingCentral
{
    public partial class GetDialingPlanInfo
    {
        // List of countries which can be selected for a dialing plan
        public GetDialingPlanCountryInfo[] @records { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
    }
}
