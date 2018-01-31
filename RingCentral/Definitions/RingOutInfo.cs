namespace RingCentral
{
    public partial class RingOutInfo
    {
        // Internal identifier of a RingOut call
        public string @id { get; set; }
        // RingOut status information
        public RingOutStatusInfo @status { get; set; }
    }
}
