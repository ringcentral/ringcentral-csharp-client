using System.Threading.Tasks;
namespace RingCentral
{
    public partial class VerifyPath : PathSegment
    {
        internal VerifyPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "verify";
            }
        }
    }
}
