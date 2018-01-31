namespace RingCentral
{
    public partial class TranscriptionResult
    {
        //
        public string @STTId { get; set; }
        //
        public string @ExternalId { get; set; }
        //
        public long? @Status { get; set; }
        //
        public string @Mailbox { get; set; }
        //
        public string @TranscriptionText { get; set; }
        //
        public string @Message { get; set; }
        //
        public string @MessageLength { get; set; }
        //
        public string @Confidence { get; set; }
    }
}
