namespace RingCentral
{
    public partial class CompanyDirectoryContacts
    {
        // List of countries which can be selected for a dialing plan
        public CompanyDirectoryContactInfo[] @records { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
