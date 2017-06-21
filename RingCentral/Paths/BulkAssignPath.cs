using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BulkAssignPath : PathSegment
    {
        internal BulkAssignPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "bulk-assign";
            }
        }
        // Edit Group Members
        public Task<GlipGroupInfo> Post()
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), null);
        }
        // Edit Group Members
        public Task<GlipGroupInfo> Post(object parameters)
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), parameters);
        }
        // Edit Group Members
        public Task<GlipGroupInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // List of users to be added to the team
            public string[] @addedPersonIds { get; set; }
            // List of user email addresses to be added to the team (i.e. as guests)
            public string[] @addedPersonEmails { get; set; }
            // List of users to be removed from the team
            public string[] @removedPersonIds { get; set; }
        }
    }
}
