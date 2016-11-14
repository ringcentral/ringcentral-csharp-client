using System.Threading.Tasks;
namespace RingCentral
{
    public partial class NumberPoolPath : Model
    {
        internal NumberPoolPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
