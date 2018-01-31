namespace RingCentral
{
    public partial class GroupsCollection
    {
        //
        public string @uri { get; set; }
        //
        public GroupResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
