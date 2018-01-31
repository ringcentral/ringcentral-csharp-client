using System.Threading.Tasks;
namespace RingCentral
{
    public partial class LinePath : PathSegment
    {
        internal LinePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "line";
            }
        }
    }
}
