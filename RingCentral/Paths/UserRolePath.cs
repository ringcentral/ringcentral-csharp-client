using System.Threading.Tasks;
namespace RingCentral
{
    public partial class UserRolePath : PathSegment
    {
        internal UserRolePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "user-role";
            }
        }
        public DefaultPath Default()
        {
            return new DefaultPath(this);
        }
    }
}
