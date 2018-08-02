using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CheckPath : PathSegment
    {
        internal CheckPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "check";
            }
        }
        // Checks if a certain user permission is activated for a particular extension.
        public Task<AuthProfileCheckResource> Get()
        {
            return RC.Get<AuthProfileCheckResource>(Endpoint(true), null);
        }
        // Checks if a certain user permission is activated for a particular extension.
        public Task<AuthProfileCheckResource> Get(object parameters)
        {
            return RC.Get<AuthProfileCheckResource>(Endpoint(true), parameters);
        }
        // Checks if a certain user permission is activated for a particular extension.
        public Task<AuthProfileCheckResource> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            //
            public string @permissionId { get; set; }
            //
            public string @targetExtensionId { get; set; }
        }
    }
}
