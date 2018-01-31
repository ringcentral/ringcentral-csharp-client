namespace RingCentral
{
    public partial class GlipCreatePost
    {
        // Internal identifier of a group to send post to
        public string @groupId { get; set; }
        // Text of a post, the maximum is 10000 characters
        public string @text { get; set; }
        // List of attachments to be posted
        public GlipAttachmentInfoRequest[] @attachments { get; set; }
    }
}
