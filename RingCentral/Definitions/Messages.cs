namespace RingCentral
{
    public partial class Messages
    {
        //
        public string @uri { get; set; }
        //
        public MessageInfoResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
