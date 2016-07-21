
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class End : Model
    {
        internal End(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "end";
            }
        }
    }
}
