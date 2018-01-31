namespace RingCentral
{
    public partial class PresenceLinesNavigationResource
    {
        //
        public string @uri { get; set; }
        //
        public PresenceLineResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
