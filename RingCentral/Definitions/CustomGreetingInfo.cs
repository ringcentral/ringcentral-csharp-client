namespace RingCentral
{
    public partial class CustomGreetingInfo
    {
        // Link to an extension custom greeting
        public string @uri { get; set; }
        // Internal identifier of an answering rule
        public string @id { get; set; }
        // Type of a greeting, specifying the case when the greeting is played. See also Greeting Types
        public string @type { get; set; }
        // Content media type in WAV/MP3 format
        public string @contentType { get; set; }
        // Link to a greeting content (audio file)
        public string @contentUri { get; set; }
    }
}
