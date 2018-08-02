using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DevicesPath : PathSegment
    {
        internal DevicesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "devices";
            }
        }
        // Returns the list of paging devices assigned to this group.
        public Task<PagingOnlyGroupDevices> List()
        {
            return RC.Get<PagingOnlyGroupDevices>(Endpoint(false), null);
        }
        // Returns the list of paging devices assigned to this group.
        public Task<PagingOnlyGroupDevices> List(object parameters)
        {
            return RC.Get<PagingOnlyGroupDevices>(Endpoint(false), parameters);
        }
        // Returns the list of paging devices assigned to this group.
        public Task<PagingOnlyGroupDevices> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
        }
    }
}
