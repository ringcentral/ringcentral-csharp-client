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
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns list of posts.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipPosts> List()
        {
            return RC.Get<GlipPosts>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns list of posts.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipPosts> List(object parameters)
        {
            return RC.Get<GlipPosts>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns list of posts.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipPosts> List(ListParameters parameters)
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
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Creates a post.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipPostInfo> Post()
        {
            return RC.Post<GlipPostInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Creates a post.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipPostInfo> Post(object parameters)
        {
            return RC.Post<GlipPostInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Creates a post.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipPostInfo> Post(GlipCreatePost parameters)
        {
            return Post(parameters as object);
        }
    }
}
