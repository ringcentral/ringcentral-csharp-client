namespace RingCentral
{
    public partial class RoleResource
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
        public bool? @custom { get; set; }
        //
        public string @scope { get; set; }
        //
        public bool? @hidden { get; set; }
        //
        public string @lastUpdated { get; set; }
        //
        public PermissionIdResource[] @permissions { get; set; }
    }
}
