using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FaxPath : PathSegment
    {
        internal FaxPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "fax";
            }
        }
    }
}
