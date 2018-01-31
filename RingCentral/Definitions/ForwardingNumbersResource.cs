namespace RingCentral
{
    public partial class ForwardingNumbersResource
    {
        //
        public string @uri { get; set; }
        //
        public ForwardingNumberResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
