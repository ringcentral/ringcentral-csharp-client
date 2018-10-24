namespace RingCentral
{
    public partial class GlipChatInfo
    {
        // Internal identifier of a chat
        public string @id { get; set; }
        // Type of a chat
        public string @type { get; set; }
        // For 'Team' chat type only. Team access level.
        public bool? @public { get; set; }
        // For 'Team','Everyone' chats types only. Chat name.
        public string @name { get; set; }
        // For 'Team','Everyone' chats types only. Chat description.
        public string @description { get; set; }
        // For 'Team' chat type only. Team status.
        public string @status { get; set; }
        // Chat creation datetime in ISO 8601 format
        public string @creationTime { get; set; }
        // Chat last change datetime in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
