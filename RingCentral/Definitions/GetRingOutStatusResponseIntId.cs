namespace RingCentral
{
    public partial class GetRingOutStatusResponseIntId
    {
        // Internal identifier of a RingOut call
        public long? @id { get; set; }
        //
        public string @uri { get; set; }
        // RingOut status information
        public RingOutStatusInfo @status { get; set; }
    }
}
