using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MessageStorePath : PathSegment
    {
        internal MessageStorePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "message-store";
            }
        }
        public ContentPath Content(string _id)
        {
            return new ContentPath(this, _id);
        }
        public ContentPath Content()
        {
            return new ContentPath(this);
        }
        // Returns the list of messages from an extension mailbox.
        public Task<GetMessageList> List()
        {
            return RC.Get<GetMessageList>(Endpoint(false), null);
        }
        // Returns the list of messages from an extension mailbox.
        public Task<GetMessageList> List(object parameters)
        {
            return RC.Get<GetMessageList>(Endpoint(false), parameters);
        }
        // Returns the list of messages from an extension mailbox.
        public Task<GetMessageList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Specifies the availability status for the resulting messages. Multiple values are accepted
            public string[] @availability { get; set; }
            // Specifies the conversation identifier for the resulting messages
            public long? @conversationId { get; set; }
            // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string @dateFrom { get; set; }
            // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            // The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
            public string[] @direction { get; set; }
            // If 'True', then the latest messages per every conversation ID are returned
            public bool? @distinctConversations { get; set; }
            // The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted
            public string[] @messageType { get; set; }
            // The read status for the resulting messages. Multiple values are accepted
            public string[] @readStatus { get; set; }
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // The phone number. If specified, messages are returned for this particular phone number only
            public string @phoneNumber { get; set; }
        }
        // Deletes conversation(s) by conversation ID(s).
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Deletes conversation(s) by conversation ID(s).
        public async Task<bool> Delete(object parameters)
        {
            await RC.Delete(Endpoint(true), parameters);
            return true;
        }
        // Deletes conversation(s) by conversation ID(s).
        public Task<bool> Delete(DeleteParameters parameters)
        {
            return Delete(parameters as object);
        }
        public partial class DeleteParameters
        {
            //
            public string[] @conversationId { get; set; }
            // Messages received earlier then the date specified will be deleted. The default value is 'Now'
            public string @dateTo { get; set; }
            // Type of messages to be deleted
            public string @type { get; set; }
        }
        // Returns individual message record(s) by the given message ID(s). The length of inbound messages is unlimited. Batch request is supported.
        public Task<GetMessageInfoResponse> Get()
        {
            return RC.Get<GetMessageInfoResponse>(Endpoint(true), null);
        }
        // Updates message(s) by ID(s). Batch request is supported, see Batch Requests for details. Currently, only the message read status updating is supported.
        public Task<GetMessageInfoResponse> Put()
        {
            return RC.Put<GetMessageInfoResponse>(Endpoint(true), null);
        }
        // Updates message(s) by ID(s). Batch request is supported, see Batch Requests for details. Currently, only the message read status updating is supported.
        public Task<GetMessageInfoResponse> Put(object parameters)
        {
            return RC.Put<GetMessageInfoResponse>(Endpoint(true), parameters);
        }
        // Updates message(s) by ID(s). Batch request is supported, see Batch Requests for details. Currently, only the message read status updating is supported.
        public Task<GetMessageInfoResponse> Put(UpdateMessageRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
