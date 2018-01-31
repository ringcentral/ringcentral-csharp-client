using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PermissionCategoryPath : PathSegment
    {
        internal PermissionCategoryPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "permission-category";
            }
        }
    }
}
