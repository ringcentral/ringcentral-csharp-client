namespace RingCentral
{
    public partial class RCVRecordingInfo
    {
        // Meeting record size in bytes
        public long? @size { get; set; }
        // Meeting duration in seconds
        public long? @duration { get; set; }
        // Link to a meeting record
        public string @url { get; set; }
    }
}
