using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DepartmentPath : Model
    {
        internal DepartmentPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
    }
}
