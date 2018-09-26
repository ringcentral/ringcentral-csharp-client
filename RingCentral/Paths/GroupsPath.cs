using System.Threading.Tasks;
namespace RingCentral
{
    public partial class GroupsPath : PathSegment
    {
        internal GroupsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "groups";
            }
        }
        public BulkAssignPath BulkAssign()
        {
            return new BulkAssignPath(this);
        }
        public PostsPath Posts()
        {
            return new PostsPath(this);
        }
        public EventsPath Events(string _id)
        {
            return new EventsPath(this, _id);
        }
        public EventsPath Events()
        {
            return new EventsPath(this);
        }
        public NotesPath Notes(string _id)
        {
            return new NotesPath(this, _id);
        }
        public NotesPath Notes()
        {
            return new NotesPath(this);
        }
        public WebhooksPath Webhooks(string _id)
        {
            return new WebhooksPath(this, _id);
        }
        public WebhooksPath Webhooks()
        {
            return new WebhooksPath(this);
        }
        // Returns the list of groups where the user is a member.
        public Task<GlipGroupList> List()
        {
            return RC.Get<GlipGroupList>(Endpoint(false), null);
        }
        // Returns the list of groups where the user is a member.
        public Task<GlipGroupList> List(object parameters)
        {
            return RC.Get<GlipGroupList>(Endpoint(false), parameters);
        }
        // Returns the list of groups where the user is a member.
        public Task<GlipGroupList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Type of groups to be fetched (by default all type of groups will be fetched)
            public string @type { get; set; }
            // Max number of groups to be fetched by one request.
            public double? @recordCount { get; set; }
            // Pagination token.
            public string @pageToken { get; set; }
        }
        // Creates a new private chat/team.
        public Task<GlipGroupInfo> Post()
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), null);
        }
        // Creates a new private chat/team.
        public Task<GlipGroupInfo> Post(object parameters)
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), parameters);
        }
        // Creates a new private chat/team.
        public Task<GlipGroupInfo> Post(GlipCreateGroup parameters)
        {
            return Post(parameters as object);
        }
        // Returns information about a group or multiple groups by their ID(s). Batch request is supported.
        public Task<GlipGroupInfo> Get()
        {
            return RC.Get<GlipGroupInfo>(Endpoint(true), null);
        }
    }
}
