using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DepartmentPath : PathSegment
    {
        internal DepartmentPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "department";
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
    }
}
