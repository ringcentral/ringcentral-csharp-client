using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BannersPath : PathSegment
    {
        internal BannersPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "banners";
            }
        }
    }
}
