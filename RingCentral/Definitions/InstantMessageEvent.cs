namespace RingCentral
{
    public partial class InstantMessageEvent
    {
        // Internal identifier of a message
        public string @id { get; set; }
        // Message receiver(s) information
        public InstantMessageEvent_CallerInfo[] @to { get; set; }
        // Message sender information
        public InstantMessageEvent_CallerInfo @from { get; set; }
        // Type of a message. The default value is 'SMS'
        public string @type { get; set; }
        // Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // The datetime when the message was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @lastModifiedTime { get; set; }
        // Status of a message. The default value is 'Unread'
        public string @readStatus { get; set; }
        // The default value is 'Normal'
        public string @priority { get; set; }
        // Message attachment data
        public InstantMessageAttachmentInfo[] @attachments { get; set; }
        // Message direction. The default value is 'Inbound'
        public string @direction { get; set; }
        // Message availability status. The default value is 'Alive'
        public string @availability { get; set; }
        // Message subject. It replicates message text which is also returned as an attachment
        public string @subject { get; set; }
        // Status of a message. The default value is 'Received'
        public string @messageStatus { get; set; }
        // Identifier of the conversation the message belongs to
        public string @conversationId { get; set; }
    }
}
