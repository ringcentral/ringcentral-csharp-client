namespace RingCentral
{
    public partial class ActivePermissionResource
    {
        //
        public PermissionIdResource @permission { get; set; }
        //
        public RoleIdResource @effectiveRole { get; set; }
        //
        public string[] @scopes { get; set; }
    }
}
