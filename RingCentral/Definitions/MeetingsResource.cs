namespace RingCentral
{
    public partial class MeetingsResource
    {
        //
        public string @uri { get; set; }
        //
        public MeetingResponseResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
