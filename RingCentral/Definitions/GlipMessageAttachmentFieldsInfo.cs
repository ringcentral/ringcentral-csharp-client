namespace RingCentral
{
    public partial class GlipMessageAttachmentFieldsInfo
    {
        // Title for an individual field
        public string @title { get; set; }
        // Field Value (Supports Markdown)
        public string @value { get; set; }
        // A style used to flag fields that should span the width of the message, Defaults to 'Short' (Not full width)
        public string @style { get; set; }
    }
}
