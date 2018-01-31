namespace RingCentral
{
    public partial class ContactList
    {
        // List of personal contacts from the extension address book
        public PersonalContactResource[] @records { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
