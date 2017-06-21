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
        // Create Group
        public Task<GlipGroupInfo> Post()
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), null);
        }
        // Create Group
        public Task<GlipGroupInfo> Post(object parameters)
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), parameters);
        }
        // Create Group
        public Task<GlipGroupInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Type of a group to be created. 'PrivateChat' is a group of 2 members. 'Team' is a chat of 1 and more participants, the membership can be modified in future
            public string @type { get; set; }
            // For 'Team' group type only. Team access level
            public bool? @isPublic { get; set; }
            // For 'Team' group type only. Team name
            public string @name { get; set; }
            // For 'Team' group type only. Team description
            public string @description { get; set; }
            // Identifier(s) of group members. For 'PrivateChat' group type 2 members only are supported
            public string[] @members { get; set; }
        }
        // Get Group List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Group List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Group List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Type of a group. 'PrivateChat' is a group of 2 members. 'Group' is a chat of 2 and more participants, the membership cannot be changed after group creation. 'Team' is a chat of 1 and more participants, the membership can be modified in future
            public string @type { get; set; }
            // Token of a page to be returned, see Glip Navigation Info
            public string @pageToken { get; set; }
            // Max numbers of records to be returned. The default/maximum value is 250
            public long? @recordCount { get; set; }
        }
        public partial class ListResponse
        {
            // List of groups/teams/private chats
            public GlipGroupInfo[] @records { get; set; }
            // Information on navigation
            public GlipNavigationInfo @navigation { get; set; }
        }
        // Get Group by ID
        public Task<GlipGroupInfo> Get()
        {
            return RC.Get<GlipGroupInfo>(Endpoint(true), null);
        }
    }
}
