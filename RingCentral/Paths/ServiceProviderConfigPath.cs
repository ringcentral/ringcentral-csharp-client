using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServiceProviderConfigPath : PathSegment
    {
        internal ServiceProviderConfigPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "ServiceProviderConfig";
            }
        }
        //
        public Task<ServiceProviderConfig> Get()
        {
            return RC.Get<ServiceProviderConfig>(Endpoint(true), null);
        }
    }
}
