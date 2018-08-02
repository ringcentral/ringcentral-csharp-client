namespace RingCentral
{
    public partial class CreateInternalTextMessageRequest
    {
        // Sender of a pager message. The extensionNumber property must be filled
        public PagerCallerInfoRequest @from { get; set; }
        // Internal identifier of a message this message replies to
        public long? @replyOn { get; set; }
        // Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols
        public string @text { get; set; }
        // Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled
        public PagerCallerInfoRequest[] @to { get; set; }
    }
}
