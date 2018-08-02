using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallQueuesPath : PathSegment
    {
        internal CallQueuesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "call-queues";
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
        // Returns call queue group list
        public Task<CallQueues> List()
        {
            return RC.Get<CallQueues>(Endpoint(false), null);
        }
        // Returns call queue group list
        public Task<CallQueues> List(object parameters)
        {
            return RC.Get<CallQueues>(Endpoint(false), parameters);
        }
        // Returns call queue group list
        public Task<CallQueues> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // Internal identifier of an extension that is a member of every group within the result
            public string @memberExtensionId { get; set; }
        }
    }
}
