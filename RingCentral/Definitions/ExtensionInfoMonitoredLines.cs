namespace RingCentral
{
    public partial class ExtensionInfoMonitoredLines
    {
        // Internal identifier of a monitored extension
        public string @id { get; set; }
        // Canonical URI of a monitored extension
        public string @uri { get; set; }
        // Brief information on a monitored extension
        public string @extensionNumber { get; set; }
        // Type of a monitored extension
        public string @type { get; set; }
    }
}
