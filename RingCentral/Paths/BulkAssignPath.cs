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
        // Updates group members. Please note: Only groups of 'Team' type can be updated. Currently only one operation at a time (either adding or removal) is supported.
        public Task<GlipGroupInfo> Post()
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), null);
        }
        // Updates group members. Please note: Only groups of 'Team' type can be updated. Currently only one operation at a time (either adding or removal) is supported.
        public Task<GlipGroupInfo> Post(object parameters)
        {
            return RC.Post<GlipGroupInfo>(Endpoint(true), parameters);
        }
        // Updates group members. Please note: Only groups of 'Team' type can be updated. Currently only one operation at a time (either adding or removal) is supported.
        public Task<GlipGroupInfo> Post(EditGroupRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
