namespace RingCentral
{
    public partial class GlipPostInfo
    {
        // Internal identifier of a post
        public string @id { get; set; }
        // Internal identifier of a group a post belongs to
        public string @groupId { get; set; }
        // Type of a post
        public string @type { get; set; }
        // For 'TextMessage' post type only. Text of a message
        public string @text { get; set; }
        // Internal identifier of a user - author of a post
        public string @creatorId { get; set; }
        // For 'PersonsAdded' post type only. Identifiers of persons added to a group
        public string[] @addedPersonIds { get; set; }
        // Post creation datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string @creationTime { get; set; }
        // Post last modification datetime in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format
        public string @lastModifiedTime { get; set; }
        // List of posted attachments
        public GlipMessageAttachmentInfo[] @attachments { get; set; }
        //
        public GlipMentionsInfo[] @mentions { get; set; }
        // Label of activity type
        public string @activity { get; set; }
        // Title of a message. (Can be set for bot's messages only)
        public string @title { get; set; }
        // Link to an image used as an icon for this message
        public string @iconUri { get; set; }
        // Emoji used as an icon for this message
        public string @iconEmoji { get; set; }
    }
}
