namespace RingCentral
{
    public partial class LineInfo
    {
        // Internal identifier of a monitored extension
        public string @id { get; set; }
        // Canonical URI of a monitored extension
        public string @uri { get; set; }
        // Brief information on a monitored extension
        public ExtensionInfoMonitoredLines @extension { get; set; }
    }
}
