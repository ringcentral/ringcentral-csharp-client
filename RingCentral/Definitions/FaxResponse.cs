namespace RingCentral
{
    public partial class FaxResponse
    {
        // Internal identifier of a message
        public long? @id { get; set; }
        // Canonical URI of a message
        public string @uri { get; set; }
        // Message type - 'Fax'
        public string @type { get; set; }
        // Sender information
        public CallerInfoFrom @from { get; set; }
        // Recipient information
        public CallerInfoTo[] @to { get; set; }
        // Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @creationTime { get; set; }
        // Message read status
        public string @readStatus { get; set; }
        // Message priority
        public string @priority { get; set; }
        // The list of message attachments
        public MessageAttachmentInfoIntId[] @attachments { get; set; }
        // Message direction
        public string @direction { get; set; }
        // Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly
        public string @availability { get; set; }
        // Message status. 'Queued' - the message is queued for sending; 'Sent' - a message is successfully sent; 'SendingFailed' - a message sending attempt has failed; 'Received' - a message is received (inbound messages have this status by default)
        public string @messageStatus { get; set; }
        // Resolution of a fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
        public string @faxResolution { get; set; }
        // Page count in a fax message
        public long? @faxPageCount { get; set; }
        // Datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @lastModifiedTime { get; set; }
        // Cover page identifier. For the list of available cover page identifiers please call the method Fax Cover Pages
        public long? @coverIndex { get; set; }
        // Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        public string @coverPageText { get; set; }
    }
}
