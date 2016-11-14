namespace RingCentral
{
    public partial class MessageAttachmentInfo
    {
        // Internal identifier of a message attachment
        public string @id { get; set; }
        // Canonical URI of a message attachment
        public string @uri { get; set; }
        // Type of message attachment
        public string @type { get; set; }
        // MIME type for a given attachment, for instance 'audio/wav'
        public string @contentType { get; set; }
        // Voicemail only Duration of the voicemail in seconds
        public long? @vmDuration { get; set; }
    }
}
