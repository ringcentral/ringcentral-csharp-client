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
        // For 'TextMessage' post type only. Message text
        public string @text { get; set; }
        // Internal identifier of a user - author of a post
        public string @creatorId { get; set; }
        // For PersonsAdded post type only. Identifiers of persons added to a group
        public string[] @addedPersonIds { get; set; }
        // Post creation datetime in ISO 8601 format
        public string @creationTime { get; set; }
        // Post last modification datetime in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
