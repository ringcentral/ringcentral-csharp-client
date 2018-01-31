namespace RingCentral
{
    public partial class MessageInfoResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public CallerInfo[] @to { get; set; }
        //
        public CallerInfo @from { get; set; }
        //
        public string @type { get; set; }
        //
        public string @creationTime { get; set; }
        //
        public string @readStatus { get; set; }
        //
        public string @priority { get; set; }
        //
        public MessageAttachmentInfo[] @attachments { get; set; }
        //
        public string @direction { get; set; }
        //
        public string @availability { get; set; }
        //
        public string @subject { get; set; }
        //
        public string @messageStatus { get; set; }
        //
        public string @faxResolution { get; set; }
        //
        public long? @faxPageCount { get; set; }
        //
        public string @deliveryErrorCode { get; set; }
        //
        public string @smsDeliveryTime { get; set; }
        //
        public long? @smsSendingAttemptsCount { get; set; }
        //
        public long? @conversationId { get; set; }
        //
        public ConversationResource @conversation { get; set; }
        //
        public string @lastModifiedTime { get; set; }
        //
        public bool? @pgToDepartment { get; set; }
        //
        public string @vmTranscriptionStatus { get; set; }
        //
        public string @sourceFilePath { get; set; }
        //
        public long? @coverIndex { get; set; }
        //
        public string @coverPageText { get; set; }
    }
}
