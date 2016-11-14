using System.Threading.Tasks;
namespace RingCentral
{
    public partial class NumberParserPath : Model
    {
        internal NumberParserPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
