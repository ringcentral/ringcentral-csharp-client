namespace RingCentral
{
    public partial class MessageEventBody
    {
        // Internal identifier of an extension
        public string @extensionId { get; set; }
        // Datetime when the message was last modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @lastUpdated { get; set; }
        // Message Changes
        public MessageChanges[] @changes { get; set; }
        // Internal identifier of a subscription owner extension
        public string @ownerId { get; set; }
    }
}
