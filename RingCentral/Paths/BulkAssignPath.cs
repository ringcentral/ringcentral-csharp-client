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
        // Creates or updates the list of extensions to be recorded.
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
        // Creates or updates the list of extensions to be recorded.
        public async Task<bool> Post(object parameters)
        {
            await RC.Post(Endpoint(true), parameters);
            return true;
        }
        // Creates or updates the list of extensions to be recorded.
        public Task<bool> Post(BulkAccountCallRecordingsResource parameters)
        {
            return Post(parameters as object);
        }
    }
}
