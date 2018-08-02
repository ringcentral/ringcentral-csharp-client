namespace RingCentral
{
    public partial class GlipCreatePost
    {
        // Label of an activity type
        public string @activity { get; set; }
        // Title of a message. (Can be set for bot's messages only).
        public string @title { get; set; }
        // URI to an image to use as the icon for this message.
        public string @iconUri { get; set; }
        // Emoji to use as the icon for a message.
        public string @iconEmoji { get; set; }
        // Text of a post
        public string @text { get; set; }
        // List of attachments to be posted
        public GlipMessageAttachmentInfoRequest[] @attachments { get; set; }
    }
}
