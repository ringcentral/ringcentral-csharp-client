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
        // Get Account Service Info
        public Task<AccountServiceInfo> Get()
        {
            return RC.Get<AccountServiceInfo>(Endpoint(true), null);
        }
    }
}
