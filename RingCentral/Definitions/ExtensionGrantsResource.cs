namespace RingCentral
{
    public partial class ExtensionGrantsResource
    {
        //
        public string @uri { get; set; }
        //
        public ExtensionGrantResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
