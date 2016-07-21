
namespace RingCentral
{
    public partial class NumberPool : Model
    {
        internal NumberPool(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "number-pool";
            }
        }
        public Lookup Lookup()
        {
            return new Lookup(this);
        }
        public Reserve Reserve()
        {
            return new Reserve(this);
        }
    }
}
