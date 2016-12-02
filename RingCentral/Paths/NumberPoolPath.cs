using System.Threading.Tasks;
namespace RingCentral
{
    public partial class NumberPoolPath : PathSegment
    {
        internal NumberPoolPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "number-pool";
            }
        }
        public LookupPath Lookup()
        {
            return new LookupPath(this);
        }
        public ReservePath Reserve()
        {
            return new ReservePath(this);
        }
    }
}
