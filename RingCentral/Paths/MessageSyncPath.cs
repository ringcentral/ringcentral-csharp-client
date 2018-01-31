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
        // <p style='font-style:italic;'>Since 1.0.4 (Release 5.13)</p><p>Provides facilities to synchronize mailbox content stored externally with server state.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetMessageSyncResponse> List()
        {
            return RC.Get<GetMessageSyncResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.4 (Release 5.13)</p><p>Provides facilities to synchronize mailbox content stored externally with server state.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetMessageSyncResponse> List(object parameters)
        {
            return RC.Get<GetMessageSyncResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.4 (Release 5.13)</p><p>Provides facilities to synchronize mailbox content stored externally with server state.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetMessageSyncResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Conversation identifier for the resulting messages. Meaningful for SMS and Pager messages only.
            public long? @conversationId { get; set; }
            // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string @dateFrom { get; set; }
            // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            // Direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
            public string[] @direction { get; set; }
            // If 'True', then the latest messages per every conversation ID are returned
            public bool? @distinctConversations { get; set; }
            // Type for the resulting messages. If not specified, all types of messages are returned. Multiple values are accepted
            public string[] @messageType { get; set; }
            // Limits the number of records to be returned (works in combination with dateFrom and dateTo if specified)
            public long? @recordCount { get; set; }
            // Value of syncToken property of last sync request response
            public string @syncToken { get; set; }
            // Type of message synchronization
            public string[] @syncType { get; set; }
        }
    }
}
