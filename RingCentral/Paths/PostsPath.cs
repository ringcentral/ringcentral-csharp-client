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
        // Returns posts which are available for the current user (by group ID). The maximum number of posts returned is 250.
        public Task<GlipPosts> List()
        {
            return RC.Get<GlipPosts>(Endpoint(false), null);
        }
        // Returns posts which are available for the current user (by group ID). The maximum number of posts returned is 250.
        public Task<GlipPosts> List(object parameters)
        {
            return RC.Get<GlipPosts>(Endpoint(false), parameters);
        }
        // Returns posts which are available for the current user (by group ID). The maximum number of posts returned is 250.
        public Task<GlipPosts> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Max number of records to be returned
            public long? @recordCount { get; set; }
            // Pagination token
            public string @pageToken { get; set; }
        }
        // Creates a new post in a group specified.
        public Task<GlipPostInfo> Post()
        {
            return RC.Post<GlipPostInfo>(Endpoint(true), null);
        }
        // Creates a new post in a group specified.
        public Task<GlipPostInfo> Post(object parameters)
        {
            return RC.Post<GlipPostInfo>(Endpoint(true), parameters);
        }
        // Creates a new post in a group specified.
        public Task<GlipPostInfo> Post(GlipCreatePost parameters)
        {
            return Post(parameters as object);
        }
    }
}
