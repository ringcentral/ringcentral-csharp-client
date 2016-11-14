namespace RingCentral
{
    public partial class MessageEvent
    {
        // Internal identifier of an extension. Optional parameter
        public long? @extensionId { get; set; }
        // The datetime when the message was last modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @lastUpdated { get; set; }
        // Message changes
        public MessageChange[] @changes { get; set; }
    }
}
