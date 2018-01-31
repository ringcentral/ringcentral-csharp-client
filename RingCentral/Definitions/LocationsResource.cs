namespace RingCentral
{
    public partial class LocationsResource
    {
        //
        public string @uri { get; set; }
        //
        public LocationResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
