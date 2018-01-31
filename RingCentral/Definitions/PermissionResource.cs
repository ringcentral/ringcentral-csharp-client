namespace RingCentral
{
    public partial class PermissionResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @displayName { get; set; }
        //
        public string @description { get; set; }
        //
        public bool? @assignable { get; set; }
        //
        public bool? @readOnly { get; set; }
        //
        public PermissionCategoryIdResource @category { get; set; }
        //
        public PermissionIdResource[] @includedPermissions { get; set; }
    }
}
