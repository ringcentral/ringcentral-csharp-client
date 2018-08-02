using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MembersPath : PathSegment
    {
        internal MembersPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "members";
            }
        }
        // Returns call queue group members.
        public Task<CallQueueMembers> List()
        {
            return RC.Get<CallQueueMembers>(Endpoint(false), null);
        }
        // Returns call queue group members.
        public Task<CallQueueMembers> List(object parameters)
        {
            return RC.Get<CallQueueMembers>(Endpoint(false), parameters);
        }
        // Returns call queue group members.
        public Task<CallQueueMembers> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
        }
    }
}
