using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AuthzProfilePath : Model
    {
        internal AuthzProfilePath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "authz-profile";
            }
        }
        public CheckPath Check()
        {
            return new CheckPath(this);
        }
        // Get User Permissions
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Canonical URI of an authorization profile resource
            public string @uri { get; set; }
            // List of user permissions granted
            public UserPermission[] @permissions { get; set; }
        }
    }
}
