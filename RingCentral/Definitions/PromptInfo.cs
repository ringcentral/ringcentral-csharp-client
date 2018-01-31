namespace RingCentral
{
    public partial class PromptInfo
    {
        // Internal identifier of a prompt
        public string @uri { get; set; }
        // Link to a prompt metadata
        public string @id { get; set; }
        // Type of a prompt media content
        public string @contentType { get; set; }
        // Link to a prompt media content
        public string @contentUri { get; set; }
        // Name of a prompt
        public string @filename { get; set; }
    }
}
