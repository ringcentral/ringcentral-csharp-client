using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServiceInfoPath : Model
    {
        internal ServiceInfoPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
