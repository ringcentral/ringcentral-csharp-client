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
        // Check User Permissions
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        // Check User Permissions
        public Task<GetResponse> Get(object parameters)
        {
            return RC.Get<GetResponse>(Endpoint(true), parameters);
        }
        // Check User Permissions
        public Task<GetResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Permission to check
            public string @permissionId { get; set; }
            // Optional. Internal identifier of an extension for which user permissions are to be checked. The default value is the currently logged-in extension
            public string @targetExtensionId { get; set; }
        }
        public partial class GetResponse
        {
            // Canonical URI of a permission resource
            public string @uri { get; set; }
            // Specifies if check result is successful or not
            public bool? @successful { get; set; }
            // Information on a permission checked. Returned if successful is 'True'
            public PermissionDetailsInfo @details { get; set; }
            // List of active scopes for permission. Returned if successful is 'True'
            public string[] @scopes { get; set; }
        }
    }
}
