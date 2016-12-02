using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MessageSyncPath : PathSegment
    {
        internal MessageSyncPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "message-sync";
            }
        }
        // Message Synchronization
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        // Message Synchronization
        public Task<GetResponse> Get(object parameters)
        {
            return RC.Get<GetResponse>(Endpoint(true), parameters);
        }
        // Message Synchronization
        public Task<GetResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Conversation identifier for the resulting messages. Meaningful for SMS and Pager messages only.
            public long? @conversationId { get; set; }
            // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string @dateFrom { get; set; }
            // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            // Direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
            public string @direction { get; set; }
            // If 'True', then the latest messages per every conversation ID are returned
            public bool? @distinctConversations { get; set; }
            // Type for the resulting messages. If not specified, all types of messages are returned. Multiple values are accepted
            public string @messageType { get; set; }
            // Limits the number of records to be returned (works in combination with dateFrom and dateTo if specified)
            public long? @recordCount { get; set; }
            // Value of syncToken property of last sync request response
            public string @syncToken { get; set; }
            // Type of message synchronization
            public string @syncType { get; set; }
        }
        public partial class GetResponse
        {
            // List of message records with synchronization information
            public MessageInfo[] @records { get; set; }
            // Sync type, token and time
            public SyncInfo @syncInfo { get; set; }
        }
    }
}
