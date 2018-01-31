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
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Returns the list of messages from an extension mailbox.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetMessageList> List()
        {
            return RC.Get<GetMessageList>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Returns the list of messages from an extension mailbox.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetMessageList> List(object parameters)
        {
            return RC.Get<GetMessageList>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Returns the list of messages from an extension mailbox.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetMessageList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Specifies the availability status for the resulting messages. Default value is 'Alive'. Multiple values are accepted
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
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
            // The phone number. If specified, messages are returned for this particular phone number only
            public string @phoneNumber { get; set; }
        }
        //
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        //
        public async Task<bool> Delete(object parameters)
        {
            await RC.Delete(Endpoint(true), parameters);
            return true;
        }
        //
        public Task<bool> Delete(DeleteParameters parameters)
        {
            return Delete(parameters as object);
        }
        public partial class DeleteParameters
        {
            //
            public string[] @conversationId { get; set; }
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Returns individual message record(s) by the given message ID(s). The length of inbound messages is unlimited. Batch request is supported, see Batch Requests for details.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetMessageInfoResponse> Get()
        {
            return RC.Get<GetMessageInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Updates message(s) by ID(s). Batch request is supported, see Batch Requests for details. Currently, only the message read status updating is supported.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditMessages</td><td>Viewing and updating user messages</td></tr><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetMessageInfoResponse> Put()
        {
            return RC.Put<GetMessageInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Updates message(s) by ID(s). Batch request is supported, see Batch Requests for details. Currently, only the message read status updating is supported.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditMessages</td><td>Viewing and updating user messages</td></tr><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetMessageInfoResponse> Put(object parameters)
        {
            return RC.Put<GetMessageInfoResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Updates message(s) by ID(s). Batch request is supported, see Batch Requests for details. Currently, only the message read status updating is supported.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditMessages</td><td>Viewing and updating user messages</td></tr><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetMessageInfoResponse> Put(UpdateMessageRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
