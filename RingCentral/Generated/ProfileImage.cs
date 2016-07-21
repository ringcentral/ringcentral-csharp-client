
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ProfileImage : Model
    {
        internal ProfileImage(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "profile-image";
            }
        }
    }
}
