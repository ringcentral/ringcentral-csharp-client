namespace RingCentral
{
    public partial class GlipMessageAttachmentFootnoteInfo
    {
        // A string used to be displayed as the body of the footer.
        public string @text { get; set; }
        // A URL used to display a 32x32px icon to the left of the footer
        public string @iconUri { get; set; }
        // A Unix timestamp to be displayed to the right of the footer (prettified)
        public string @time { get; set; }
    }
}
