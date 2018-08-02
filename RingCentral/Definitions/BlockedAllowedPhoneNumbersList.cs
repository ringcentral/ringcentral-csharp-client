namespace RingCentral
{
    public partial class BlockedAllowedPhoneNumbersList
    {
        // Link to a list of blocked/allowed phone numbers resource
        public string @uri { get; set; }
        //
        public BlockedAllowedPhoneNumberInfo[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
