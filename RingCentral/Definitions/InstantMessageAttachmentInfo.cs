namespace RingCentral
{
    public partial class InstantMessageAttachmentInfo
    {
        // Internal identifier of a message attachment
        public string @id { get; set; }
        // Type of a message attachment. The default value is 'Text'
        public string @type { get; set; }
        // Content type of an attachment, see also MIME Types. The default value is 'text/plain'
        public string @contentType { get; set; }
    }
}
