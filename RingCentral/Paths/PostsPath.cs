using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PostsPath : PathSegment
    {
        internal PostsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "posts";
            }
        }
        // Create Post
        public Task<GlipPostInfo> Post()
        {
            return RC.Post<GlipPostInfo>(Endpoint(true), null);
        }
        // Create Post
        public Task<GlipPostInfo> Post(object parameters)
        {
            return RC.Post<GlipPostInfo>(Endpoint(true), parameters);
        }
        // Create Post
        public Task<GlipPostInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Internal identifier of a group to send post to
            public string @groupId { get; set; }
            // Text of a post, the maximum is 10000 characters
            public string @text { get; set; }
        }
        // Get Posts
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Posts
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Posts
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Identifier of a group to filter posts
            public string @groupId { get; set; }
            // Token of a page to be returned, see Glip Navigation Info
            public string @pageToken { get; set; }
            // Max numbers of records to be returned. The default/maximum value is 250
            public long? @recordCount { get; set; }
        }
        public partial class ListResponse
        {
            // List of posts
            public GlipPostInfo[] @records { get; set; }
            // Information on navigation
            public GlipNavigationInfo @navigation { get; set; }
        }
    }
}
