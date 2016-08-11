
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Sms : Model
    {
        internal Sms(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "sms";
            }
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public partial class PostRequest
        {
            // Sender of an SMS message. The phoneNumber property must be filled to correspond to one of the account phone numbers which is allowed to send SMS
            public CallerInfo from { get; set; }
            // Receiver of an SMS message. The phoneNumber property must be filled
            public CallerInfo[] to { get; set; }
            // Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols
            public string text { get; set; }
        }
        public partial class PostResponse
        {
            // Internal identifier of a message
            public string id { get; set; }
            // Canonical URI of a message
            public string uri { get; set; }
            // The list of message attachments
            public MessageAttachmentInfo[] attachments { get; set; }
            // Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly
            public string availability { get; set; }
            // SMS and Pager only. Identifier of the conversation the message belongs to
            public long? conversationId { get; set; }
            // Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string creationTime { get; set; }
            // SMS only. Delivery error code returned by gateway
            public string deliveryErrorCode { get; set; }
            // Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound
            public string direction { get; set; }
            // Fax only. Page count in fax message
            public long? faxPageCount { get; set; }
            // Fax only. Resolution of fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
            public string faxResolution { get; set; }
            // Sender information
            public MessageInfo_CallerInfo from { get; set; }
            // The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string lastModifiedTime { get; set; }
            // Message status. Different message types may have different allowed status values.
            public string messageStatus { get; set; }
            // Pager only True if at least one of the message recipients is Department extension
            public bool? pgToDepartment { get; set; }
            // Message priority
            public string priority { get; set; }
            // Message read status
            public string readStatus { get; set; }
            // SMS only. The datetime when outbound SMS was delivered to recipient's handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral
            public string smsDeliveryTime { get; set; }
            // SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable)
            public long? smsSendingAttemptsCount { get; set; }
            // Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment
            public string subject { get; set; }
            // Recipient information
            public MessageInfo_CallerInfo[] to { get; set; }
            // Message type
            public string type { get; set; }
            // Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned
            public string vmTranscriptionStatus { get; set; }
        }
    }
}
