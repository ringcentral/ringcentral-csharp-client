using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ChatsPath : PathSegment
    {
        internal ChatsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "chats";
            }
        }
        // Returns list of chats where user is a participant.
        public Task<GlipChatsList> List()
        {
            return RC.Get<GlipChatsList>(Endpoint(false), null);
        }
        // Returns list of chats where user is a participant.
        public Task<GlipChatsList> List(object parameters)
        {
            return RC.Get<GlipChatsList>(Endpoint(false), parameters);
        }
        // Returns list of chats where user is a participant.
        public Task<GlipChatsList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Type of chats to be fetched (by default, all type of chats will be fetched).
            public string[] @type { get; set; }
            // Max number of chats to be fetched by one request (Not more than 250).
            public double? @recordCount { get; set; }
            // Pagination token.
            public string @pageToken { get; set; }
        }
        // Returns information about a chat by ID.
        public Task<GlipChatInfo> Get()
        {
            return RC.Get<GlipChatInfo>(Endpoint(true), null);
        }
    }
}
