namespace RingCentral
{
    public partial class GetCallRecordingResponse
    {
        // Internal identifier of a call recording
        public string @id { get; set; }
        // Link to a call recording binary content
        public string @contentUri { get; set; }
        // Call recording file format. Supported format is audio/x-wav
        public string @contentType { get; set; }
        // Recorded call duration
        public long? @duration { get; set; }
    }
}
