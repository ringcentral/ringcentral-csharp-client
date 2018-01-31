namespace RingCentral
{
    public partial class StatesResource
    {
        //
        public string @uri { get; set; }
        //
        public StateResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
