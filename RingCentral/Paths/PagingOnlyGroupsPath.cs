using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PagingOnlyGroupsPath : PathSegment
    {
        internal PagingOnlyGroupsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "paging-only-groups";
            }
        }
        public UsersPath Users()
        {
            return new UsersPath(this);
        }
        public DevicesPath Devices()
        {
            return new DevicesPath(this);
        }
        public BulkAssignPath BulkAssign()
        {
            return new BulkAssignPath(this);
        }
    }
}
