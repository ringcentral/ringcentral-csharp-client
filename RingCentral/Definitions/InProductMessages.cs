namespace RingCentral
{
    public partial class InProductMessages
    {
        // Link to the in-product messages resource
        public string @uri { get; set; }
        // The list of in-product messages
        public BannerInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
