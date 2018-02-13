namespace RingCentral
{
    public partial class InboundMessageEvent
    {
        // Information on a notification
        public NotificationInfo @aps { get; set; }
        // Internal identifier of an message
        public string @messageId { get; set; }
        // Internal identifier of an conversation
        public string @conversationId { get; set; }
        // Sender phone number
        public string @from { get; set; }
        // Receiver phone number
        public string @to { get; set; }
    }
}
