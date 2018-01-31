namespace RingCentral
{
    public partial class GroupContactsCollection
    {
        //
        public string @uri { get; set; }
        //
        public PersonalContactResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
