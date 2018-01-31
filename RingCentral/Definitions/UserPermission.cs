namespace RingCentral
{
    public partial class UserPermission
    {
        // Information on a permission granted
        public UserPermissionInfo @permission { get; set; }
        // List of active scopes for permission
        public string[] @scopes { get; set; }
    }
}
