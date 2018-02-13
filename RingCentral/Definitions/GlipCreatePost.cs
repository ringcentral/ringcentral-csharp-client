namespace RingCentral
{
    public partial class GlipCreatePost
    {
        // Text of a post, the maximum is 10000 unicode characters
        public string @text { get; set; }
        // List of attachments to be posted
        public GlipMessageAttachmentInfoRequest[] @attachments { get; set; }
    }
}
