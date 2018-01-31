namespace RingCentral
{
    public partial class NavigationInfo
    {
        // Canonical URI for the first page of the list
        public NavigationInfoURI @firstPage { get; set; }
        // Canonical URI for the next page of the list
        public NavigationInfoURI @nextPage { get; set; }
        // Canonical URI for the previous page of the list
        public NavigationInfoURI @previousPage { get; set; }
        // Canonical URI for the last page of the list
        public NavigationInfoURI @lastPage { get; set; }
    }
}
