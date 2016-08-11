
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MessageStore : Model
    {
        internal MessageStore(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "message-store";
            }
        }
        public Content Content(ID _id)
        {
            return new Content(this, _id);
        }
        public Content Content()
        {
            return new Content(this, null);
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public partial class ListQueryParams
        {
            // Specifies the availability status for the resulting messages. Default value is 'Alive'. Multiple values are accepted
            public string availability { get; set; }
            // Specifies the conversation identifier for the resulting messages
            public long? conversationId { get; set; }
            // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string dateFrom { get; set; }
            // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string dateTo { get; set; }
            // The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
            public string direction { get; set; }
            // If 'True', then the latest messages per every conversation ID are returned
            public bool? distinctConversations { get; set; }
            // The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted
            public string messageType { get; set; }
            // The read status for the resulting messages. Multiple values are accepted
            public string readStatus { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public int? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public int? perPage { get; set; }
            // The phone number. If specified, messages are returned for this particular phone number only
            public string phoneNumber { get; set; }
        }
        public partial class ListResponse
        {
            // List of records with message information
            public MessageInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete(object queryParams)
        {
            return RC.Delete(Endpoint(true), queryParams);
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete(DeleteQueryParams queryParams = null)
        {
            return Delete(queryParams as object);
        }
        public partial class DeleteQueryParams
        {
            // If the value is 'True', then the message is purged immediately with all the attachments. The default value is 'False'
            public bool? purge { get; set; }
            // Internal identifier of a message thread
            public long? conversationId { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
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
            public int? faxPageCount { get; set; }
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
            public int? smsSendingAttemptsCount { get; set; }
            // Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment
            public string subject { get; set; }
            // Recipient information
            public MessageInfo_CallerInfo[] to { get; set; }
            // Message type
            public string type { get; set; }
            // Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned
            public string vmTranscriptionStatus { get; set; }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public partial class PutRequest
        {
            // Read status of a message to be changed. Multiple values are accepted
            public string readStatus { get; set; }
        }
        public partial class PutResponse
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
            public int? faxPageCount { get; set; }
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
            public int? smsSendingAttemptsCount { get; set; }
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
