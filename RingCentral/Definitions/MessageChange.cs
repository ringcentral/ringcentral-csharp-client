namespace RingCentral
{
    public partial class MessageChange
    {
        // Message type
        public string @type { get; set; }
        // The number of new messages. Can be omitted if the value is zero
        public long? @newCount { get; set; }
        // The number of updated messages. Can be omitted if the value is zero
        public long? @updatedCount { get; set; }
    }
}
