namespace RingCentral
{
    public partial class GlipMessageAttachmentInfo
    {
        // Internal identifier of an attachment
        public string @id { get; set; }
        // Type of an attachment
        public string @type { get; set; }
        // A string of default text that will be rendered in the case that the client does not support Interactive Messages
        public string @fallback { get; set; }
        // A Hex color code that determines the color of the side border of the Interactive Message
        public string @color { get; set; }
        // A pretext to the message
        public string @intro { get; set; }
        // Information about the author
        public GlipMessageAttachmentAuthorInfo @author { get; set; }
        // Message title
        public string @title { get; set; }
        // A large string field (up to 1000 chars) to be displayed as the body of a message (Supports GlipDown)
        public string @text { get; set; }
        // url used to display a single image at the bottom of a message
        public string @imageUri { get; set; }
        // url used to display a thumbnail to the right of a message (82x82)
        public string @thumbnailUri { get; set; }
        // Information on navigation
        public GlipMessageAttachmentFieldsInfo[] @fields { get; set; }
        // Message Footer
        public GlipMessageAttachmentFootnoteInfo @footnote { get; set; }
    }
}
