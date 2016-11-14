namespace RingCentral
{
    public partial class NavigationInfo
    {
        // First page of the list
        public Page @firstPage { get; set; }
        // Next page of the list
        public Page @nextPage { get; set; }
        // Previous page of the list
        public Page @previousPage { get; set; }
        // Last page of the list
        public Page @lastPage { get; set; }
    }
}
