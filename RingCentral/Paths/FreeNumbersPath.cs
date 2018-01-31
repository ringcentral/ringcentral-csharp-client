using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FreeNumbersPath : PathSegment
    {
        internal FreeNumbersPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "free-numbers";
            }
        }
    }
}
