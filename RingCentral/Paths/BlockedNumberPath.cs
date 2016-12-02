using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BlockedNumberPath : PathSegment
    {
        internal BlockedNumberPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "blocked-number";
            }
        }
        // Add New Blocked Number
        public Task<BlockedNumberInfo> Post()
        {
            return RC.Post<BlockedNumberInfo>(Endpoint(true), null);
        }
        // Add New Blocked Number
        public Task<BlockedNumberInfo> Post(object parameters)
        {
            return RC.Post<BlockedNumberInfo>(Endpoint(true), parameters);
        }
        // Add New Blocked Number
        public Task<BlockedNumberInfo> Post(BlockedNumberInfo parameters)
        {
            return Post(parameters as object);
        }
        // Get Blocked Number List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // List of blocked phone numbers
            public BlockedNumberInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Delete Blocked Number by ID
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Get Blocked Number by ID
        public Task<BlockedNumberInfo> Get()
        {
            return RC.Get<BlockedNumberInfo>(Endpoint(true), null);
        }
        // Update Blocked Number Label
        public Task<BlockedNumberInfo> Put()
        {
            return RC.Put<BlockedNumberInfo>(Endpoint(true), null);
        }
        // Update Blocked Number Label
        public Task<BlockedNumberInfo> Put(object parameters)
        {
            return RC.Put<BlockedNumberInfo>(Endpoint(true), parameters);
        }
        // Update Blocked Number Label
        public Task<BlockedNumberInfo> Put(BlockedNumberInfo parameters)
        {
            return Put(parameters as object);
        }
    }
}
