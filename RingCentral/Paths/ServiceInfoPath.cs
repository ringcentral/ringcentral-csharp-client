using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServiceInfoPath : PathSegment
    {
        internal ServiceInfoPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "service-info";
            }
        }
        // Returns the information about service plan, available features and limitations for a particular RingCentral customer account.
        public Task<GetServiceInfoResponse> Get()
        {
            return RC.Get<GetServiceInfoResponse>(Endpoint(true), null);
        }
    }
}
