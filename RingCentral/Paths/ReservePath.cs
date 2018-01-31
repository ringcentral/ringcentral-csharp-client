using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ReservePath : PathSegment
    {
        internal ReservePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "reserve";
            }
        }
    }
}
