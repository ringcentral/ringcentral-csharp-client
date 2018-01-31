namespace RingCentral
{
    public partial class TimezonesResource
    {
        //
        public string @uri { get; set; }
        //
        public TimezoneResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
