using System.Threading.Tasks;
namespace RingCentral
{
    public partial class OrderPath : PathSegment
    {
        internal OrderPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "order";
            }
        }
    }
}
