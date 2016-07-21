
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Lookup : Model
    {
        internal Lookup(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "lookup";
            }
        }
    }
}
