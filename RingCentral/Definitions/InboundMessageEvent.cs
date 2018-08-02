namespace RingCentral
{
    public partial class InboundMessageEvent
    {
        // Information on a notification
        public NotificationInfo @aps { get; set; }
        // Internal identifier of a message
        public string @messageId { get; set; }
        // Internal identifier of an conversation
        public string @conversationId { get; set; }
        // Sender phone number. For GCM transport type '_from' property should be used
        public string @from { get; set; }
        // Receiver phone number
        public string @to { get; set; }
        // Internal identifier of a subscription owner extension
        public string @ownerId { get; set; }
    }
}
