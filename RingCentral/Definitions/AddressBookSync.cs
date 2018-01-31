namespace RingCentral
{
    public partial class AddressBookSync
    {
        //
        public string @uri { get; set; }
        //
        public PersonalContactResource[] @records { get; set; }
        //
        public SyncInfo @syncInfo { get; set; }
        //
        public long? @nextPageId { get; set; }
        //
        public string @nextPageUri { get; set; }
    }
}
