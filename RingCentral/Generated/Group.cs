
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Group : Model
    {
        internal Group(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "group";
            }
        }
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // List of groups
            public GroupInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of a group
            public string id { get; set; }
            // Canonical URI of a group
            public string uri { get; set; }
            // Amount of contacts in a group
            public int? contactsCount { get; set; }
            // Name of a group
            public string groupName { get; set; }
            // Notes for a group
            public string notes { get; set; }
        }
    }
}
