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
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns the list of groups associated with the user.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GlipGroupList> List()
        {
            return RC.Get<GlipGroupList>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns the list of groups associated with the user.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GlipGroupList> List(object parameters)
        {
            return RC.Get<GlipGroupList>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns the list of groups associated with the user.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GlipGroupList> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Type of a group. 'PrivateChat' is a group of 2 members. 'Group' is a chat of 2 and more participants, the membership cannot be changed after group creation. 'Team' is a chat of 1 and more participants, the membership can be modified in future
            public string[] @type { get; set; }
            // Token of a page to be returned, see Glip Navigation Info
            public string @pageToken { get; set; }
            // Max numbers of records to be returned. The default/maximum value is 250
            public long? @recordCount { get; set; }
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Creates a group.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GlipGroupInfo> Post()
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Creates a group.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GlipGroupInfo> Post(object parameters)
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Creates a group.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GlipGroupInfo> Post(GlipCreateGroup parameters)
        {
            return Post(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns a group or few groups by ID(s). Batch request is supported.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipGroupInfo> Get()
        {
            return RC.Get<GlipGroupInfo>(Endpoint(true), null);
        }
    }
}
