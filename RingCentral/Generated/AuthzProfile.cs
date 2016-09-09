
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AuthzProfile : Model
    {
        internal AuthzProfile(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "authz-profile";
            }
        }
        public Check Check()
        {
            return new Check(this);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public partial class GetResponse
        {
            // Canonical URI of an authorization profile resource
            public string uri { get; set; }
            // List of user permissions granted
            public UserPermission[] permissions { get; set; }
        }
    }
}
