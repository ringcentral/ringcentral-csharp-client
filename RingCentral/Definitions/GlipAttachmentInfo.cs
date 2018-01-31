namespace RingCentral
{
    public partial class GlipAttachmentInfo
    {
        // Internal identifier of an attachment
        public string @id { get; set; }
        // Type of an attachment
        public string @type { get; set; }
        // Link to binary content
        public string @contentUri { get; set; }
        // Name of a file
        public string @name { get; set; }
    }
}
