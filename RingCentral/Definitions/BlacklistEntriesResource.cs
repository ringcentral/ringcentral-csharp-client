namespace RingCentral
{
    public partial class BlacklistEntriesResource
    {
        //
        public string @uri { get; set; }
        //
        public BlacklistEntryResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
