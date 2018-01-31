using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ProfilePath : PathSegment
    {
        internal ProfilePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "profile";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.30 (Release 9.1)</p><p>Returns Glip unread message count.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipUnreadMessageCount> Get()
        {
            return RC.Get<GlipUnreadMessageCount>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.30 (Release 9.1)</p><p>Returns Glip unread message count.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipUnreadMessageCount> Get(object parameters)
        {
            return RC.Get<GlipUnreadMessageCount>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.30 (Release 9.1)</p><p>Returns Glip unread message count.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>Glip</td><td>Availability of Glip</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<GlipUnreadMessageCount> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // List of attributes to be returned. To return unread message count 'unreadPostsCount' and 'tooManyUnreadPosts' should be specified
            public string @fields { get; set; }
        }
    }
}
