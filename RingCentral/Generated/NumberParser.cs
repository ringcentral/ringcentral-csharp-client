
namespace RingCentral
{
    public partial class NumberParser : Model
    {
        internal NumberParser(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "number-parser";
            }
        }
        public Parse Parse()
        {
            return new Parse(this);
        }
    }
}
