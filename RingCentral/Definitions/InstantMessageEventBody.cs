namespace RingCentral
{
    public partial class InstantMessageEventBody
    {
        // Internal identifier of a message
        public string @id { get; set; }
        // Message receiver(s) information
        public NotificationRecipientInfo[] @to { get; set; }
        // Extension Type. For GCM transport type '_from' property should be used
        public SenderInfo @from { get; set; }
        // Type of a message. The default value is 'SMS'
        public string @type { get; set; }
        // Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // Datetime when the message was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @lastModifiedTime { get; set; }
        // Status of a message
        public string @readStatus { get; set; }
        //
        public string @priority { get; set; }
        // Message attachment data
        public MessageAttachmentInfo[] @attachments { get; set; }
        // Message direction
        public string @direction { get; set; }
        // Message availability status
        public string @availability { get; set; }
        // Message subject. It replicates message text which is also returned as an attachment
        public string @subject { get; set; }
        // Status of a message
        public string @messageStatus { get; set; }
        // Deprecated. Identifier of a conversation the message belongs to
        public string @conversationId { get; set; }
        // Information about a conversation the message belongs to
        public object @conversation { get; set; }
        // Internal identifier of a subscription owner extension
        public string @ownerId { get; set; }
    }
}
