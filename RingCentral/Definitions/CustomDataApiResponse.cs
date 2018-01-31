namespace RingCentral
{
    public partial class CustomDataApiResponse
    {
        // Custom data access key
        public string @id { get; set; }
        // Link to the custom data
        public string @uri { get; set; }
        // Description of custom data
        public string @value { get; set; }
        // Time of the last change in custom data
        public string @lastModifiedTime { get; set; }
        // Attachment data: link and type
        public CustomDataAttachmentInfo @attachment { get; set; }
    }
}
