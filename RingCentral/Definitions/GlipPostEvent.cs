namespace RingCentral
{
    public partial class GlipPostEvent
    {
        // Internal identifier of a post
        public string @id { get; set; }
        // Type of a post event
        public string @eventType { get; set; }
        // Internal identifier of a group a post belongs to
        public string @groupId { get; set; }
        // Type of a post. 'TextMessage' - an incoming text message; 'PersonJoined' - a message notifying that person has joined a conversation; 'PersonsAdded' - a message notifying that a person(s) were added to a conversation
        public string @type { get; set; }
        // For 'TextMessage' post type only. Message text
        public string @text { get; set; }
        // Internal identifier of a user - author of a post
        public string @creatorId { get; set; }
        // For PersonsAdded post type only. Identifiers of persons added to a group
        public string[] @addedPersonIds { get; set; }
        // For PersonsRemoved post type only. Identifiers of persons removed from a group
        public string[] @removedPersonIds { get; set; }
        // Post creation datetime in ISO 8601 format
        public string @creationTime { get; set; }
        // Post last change datetime in ISO 8601 format
        public string @lastModifiedTime { get; set; }
    }
}
