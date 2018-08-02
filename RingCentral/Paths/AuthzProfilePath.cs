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
        // Returns a list of user permissions granted at authorization procedure. Please note: Some permissions may be restricted by extension type.
        public Task<AuthProfileResource> Get()
        {
            return RC.Get<AuthProfileResource>(Endpoint(true), null);
        }
    }
}
