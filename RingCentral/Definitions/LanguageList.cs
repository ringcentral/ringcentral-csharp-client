namespace RingCentral
{
    public partial class LanguageList
    {
        // Canonical URI of the language list resource
        public string @uri { get; set; }
        // Language data
        public LanguageInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
