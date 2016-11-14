using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DevicePath : Model
    {
        internal DevicePath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "device";
            }
        }
        // Get Account Device List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // List of extension records
            public DeviceInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get Device by ID
        public Task<DeviceInfo> Get()
        {
            return RC.Get<DeviceInfo>(Endpoint(true), null);
        }
    }
}
