using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallMonitoringGroupsPath : PathSegment
    {
        internal CallMonitoringGroupsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "call-monitoring-groups";
            }
        }
        public MembersPath Members()
        {
            return new MembersPath(this);
        }
        public BulkAssignPath BulkAssign()
        {
            return new BulkAssignPath(this);
        }
        // Returns call monitoring groups that can be filtered by some extension.
        public Task<CallMonitoringGroups> List()
        {
            return RC.Get<CallMonitoringGroups>(Endpoint(false), null);
        }
        // Returns call monitoring groups that can be filtered by some extension.
        public Task<CallMonitoringGroups> List(object parameters)
        {
            return RC.Get<CallMonitoringGroups>(Endpoint(false), parameters);
        }
        // Returns call monitoring groups that can be filtered by some extension.
        public Task<CallMonitoringGroups> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // Internal identifier of an extension that is a member of every group within the result
            public string @memberExtensionId { get; set; }
        }
    }
}
