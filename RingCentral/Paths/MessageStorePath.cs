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
        // Get Message List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Message List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Message List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Specifies the availability status for the resulting messages. Default value is 'Alive'. Multiple values are accepted
            public string @availability { get; set; }
            // Specifies the conversation identifier for the resulting messages
            public long? @conversationId { get; set; }
            // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string @dateFrom { get; set; }
            // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            // The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
            public string @direction { get; set; }
            // If 'True', then the latest messages per every conversation ID are returned
            public bool? @distinctConversations { get; set; }
            // The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted
            public string @messageType { get; set; }
            // The read status for the resulting messages. Multiple values are accepted
            public string @readStatus { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
            // The phone number. If specified, messages are returned for this particular phone number only
            public string @phoneNumber { get; set; }
        }
        public partial class ListResponse
        {
            // List of records with message information
            public MessageInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Delete Message by ID
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Delete Message by ID
        public async Task<bool> Delete(object parameters)
        {
            await RC.Delete(Endpoint(true), parameters);
            return true;
        }
        // Delete Message by ID
        public Task<bool> Delete(DeleteParameters parameters)
        {
            return Delete(parameters as object);
        }
        public partial class DeleteParameters
        {
            // If the value is 'True', then the message is purged immediately with all the attachments. The default value is 'False'
            public bool? @purge { get; set; }
            // Internal identifier of a message thread
            public long? @conversationId { get; set; }
        }
        // Get Message by ID
        public Task<MessageInfo> Get()
        {
            return RC.Get<MessageInfo>(Endpoint(true), null);
        }
        // Update Message by ID
        public Task<MessageInfo> Put()
        {
            return RC.Put<MessageInfo>(Endpoint(true), null);
        }
        // Update Message by ID
        public Task<MessageInfo> Put(object parameters)
        {
            return RC.Put<MessageInfo>(Endpoint(true), parameters);
        }
        // Update Message by ID
        public Task<MessageInfo> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // Read status of a message to be changed. Multiple values are accepted
            public string @readStatus { get; set; }
        }
    }
}
