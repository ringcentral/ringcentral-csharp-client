namespace RingCentral
{
    public partial class ContactsCollection
    {
        //
        public string @uri { get; set; }
        //
        public PersonalContactResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
        //
        public ResourceLink @groups { get; set; }
    }
}
