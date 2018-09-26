namespace RingCentral
{
    public partial class GlipMessageAttachmentFootnoteInfo
    {
        // Text of a footer
        public string @text { get; set; }
        // Link to an icon displayed to the left of a footer; sized 32x32px
        public string @iconUri { get; set; }
        // Message creation datetime in ISO 8601 format including timezone, for example *2016-03-10T18:07:52.534Z*
        public string @time { get; set; }
    }
}
