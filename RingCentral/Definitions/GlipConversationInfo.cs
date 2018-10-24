namespace RingCentral
{
    public partial class GlipConversationInfo
    {
        // Internal identifier of a conversation
        public string @id { get; set; }
        // Type of a conversation
        public string @type { get; set; }
        // Conversation creation datetime in ISO 8601 format
        public string @creationTime { get; set; }
        // Conversation last change datetime in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
