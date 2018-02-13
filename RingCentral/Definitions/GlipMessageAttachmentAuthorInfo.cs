namespace RingCentral
{
    public partial class GlipMessageAttachmentAuthorInfo
    {
        // The author name
        public string @name { get; set; }
        // Used to link the authors name
        public string @uri { get; set; }
        // A url to an image up to 82x82px that will display to the left of the author’s name
        public string @iconUri { get; set; }
    }
}
