
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Revoke : Model
    {
        internal Revoke(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "revoke";
            }
        }
    }
}
