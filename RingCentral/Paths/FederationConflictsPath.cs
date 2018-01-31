using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FederationConflictsPath : PathSegment
    {
        internal FederationConflictsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "federation-conflicts";
            }
        }
    }
}
