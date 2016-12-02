using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AuthzProfilePath : PathSegment
    {
        internal AuthzProfilePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
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
