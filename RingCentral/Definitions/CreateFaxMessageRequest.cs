namespace RingCentral
{
    public partial class CreateFaxMessageRequest
    {
        // Recipient information. Phone number property is mandatory. Optional for resend fax request
        public MessageStoreCallerInfoRequest[] @to { get; set; }
        // Fax resolution
        public string @resolution { get; set; }
        // The datetime to send fax at, in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If time is not specified, the fax will be send immediately
        public string @sendTime { get; set; }
        // Optional. Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        public string @coverPageText { get; set; }
        // Internal identifier of the original fax message which needs to be resent. Mandatory for resend fax request
        public string @originalMessageId { get; set; }
    }
}
