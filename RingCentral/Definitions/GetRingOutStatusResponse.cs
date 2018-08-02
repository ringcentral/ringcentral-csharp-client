namespace RingCentral
{
    public partial class GetRingOutStatusResponse
    {
        // Internal identifier of a RingOut call
        public string @id { get; set; }
        //
        public string @uri { get; set; }
        // RingOut status information
        public RingOutStatusInfo @status { get; set; }
    }
}
