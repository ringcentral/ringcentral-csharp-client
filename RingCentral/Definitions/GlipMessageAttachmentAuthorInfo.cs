namespace RingCentral
{
    public partial class GlipMessageAttachmentAuthorInfo
    {
        // Name of a message author
        public string @name { get; set; }
        // Link to an author's name
        public string @uri { get; set; }
        // Link to an image displayed to the left of an author's name; sized 82x82px
        public string @iconUri { get; set; }
    }
}
