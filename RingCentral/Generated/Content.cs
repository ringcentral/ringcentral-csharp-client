
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Content : Model
    {
        internal Content(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "content";
            }
        }
    }
}
