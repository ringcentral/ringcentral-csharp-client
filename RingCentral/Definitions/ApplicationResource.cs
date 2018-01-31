namespace RingCentral
{
    public partial class ApplicationResource
    {
        //
        public string @id { get; set; }
        //
        public string @name { get; set; }
        //
        public string @description { get; set; }
        //
        public OrganizationResource @organization { get; set; }
        //
        public string @scope { get; set; }
        //
        public string @platformType { get; set; }
        //
        public PermissionResource[] @permissions { get; set; }
    }
}
