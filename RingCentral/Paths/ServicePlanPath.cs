using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServicePlanPath : PathSegment
    {
        internal ServicePlanPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "service-plan";
            }
        }
    }
}
