namespace RingCentral
{
    public partial class CompanyAnsweringRuleList
    {
        // Link to an answering rule resource
        public string @uri { get; set; }
        // List of company answering rules
        public ListCompanyAnsweringRuleInfo[] @records { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
    }
}
