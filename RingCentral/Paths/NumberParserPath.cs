using System.Threading.Tasks;
namespace RingCentral
{
    public partial class NumberParserPath : PathSegment
    {
        internal NumberParserPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "number-parser";
            }
        }
        public ParsePath Parse()
        {
            return new ParsePath(this);
        }
    }
}
