
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServiceInfo : Model
    {
        internal ServiceInfo(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "service-info";
            }
        }
    }
}
