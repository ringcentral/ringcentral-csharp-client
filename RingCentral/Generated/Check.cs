
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Check : Model
    {
        internal Check(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "check";
            }
        }
        public Task<GetResponse> Get(object queryParams)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return Get(queryParams as object);
        }
        public partial class GetQueryParams
        {
            // Permission to check
            public string permissionId { get; set; }
            // Optional. Internal identifier of an extension for which user permissions are to be checked. The default value is the currently logged-in extension
            public string targetExtensionId { get; set; }
        }
        public partial class GetResponse
        {
            // Canonical URI of a permission resource
            public string uri { get; set; }
            // Specifies if check result is successful or not
            public bool? successful { get; set; }
            // Information on a permission checked. Returned if successful is 'True'
            public PermissionDetailsInfo details { get; set; }
            // List of active scopes for permission. Returned if successful is 'True'
            public string[] scopes { get; set; }
        }
    }
}
