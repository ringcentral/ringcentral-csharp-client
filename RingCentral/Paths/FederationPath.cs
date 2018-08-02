using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FederationPath : PathSegment
    {
        internal FederationPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "federation";
            }
        }
        // Returns information on a federation and associated accounts.
        public Task<FederationResource> Get()
        {
            return RC.Get<FederationResource>(Endpoint(true), null);
        }
    }
}
