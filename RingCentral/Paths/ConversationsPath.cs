using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ConversationsPath : PathSegment
    {
        internal ConversationsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "conversations";
            }
        }
        // Returns list of conversations where user is participant.
        public Task<GlipConversationsList> List()
        {
            return RC.Get<GlipConversationsList>(Endpoint(false), null);
        }
        // Returns list of conversations where user is participant.
        public Task<GlipConversationsList> List(object parameters)
        {
            return RC.Get<GlipConversationsList>(Endpoint(false), parameters);
        }
        // Returns list of conversations where user is participant.
        public Task<GlipConversationsList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Max number of conversations to be fetched by one request (Not more than 250).
            public double? @recordCount { get; set; }
            // Pagination token.
            public string @pageToken { get; set; }
        }
        // Returns information about a conversation by ID.
        public Task<GlipConversationInfo> Get()
        {
            return RC.Get<GlipConversationInfo>(Endpoint(true), null);
        }
    }
}
