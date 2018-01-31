using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DefaultPath : PathSegment
    {
        internal DefaultPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "default";
            }
        }
    }
}
