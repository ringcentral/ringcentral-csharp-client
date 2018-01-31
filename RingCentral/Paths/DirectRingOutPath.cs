using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DirectRingOutPath : PathSegment
    {
        internal DirectRingOutPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "direct-ring-out";
            }
        }
    }
}
