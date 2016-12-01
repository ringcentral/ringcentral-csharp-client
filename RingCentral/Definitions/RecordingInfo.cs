namespace RingCentral
{
    public partial class RecordingInfo
    {
        // Internal identifier of the call recording
        public string @id { get; set; }
        // Link to the call recording metadata resource
        public string @uri { get; set; }
        // Indicates recording mode used
        public string @type { get; set; }
        // Link to the call recording binary content
        public string @contentUri { get; set; }
    }
}
