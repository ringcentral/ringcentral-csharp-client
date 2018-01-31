using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BrandPath : PathSegment
    {
        internal BrandPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "brand";
            }
        }
    }
}
