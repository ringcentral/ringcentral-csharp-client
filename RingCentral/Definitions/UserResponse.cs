namespace RingCentral
{
    public partial class UserResponse
    {
        // user status
        public bool? @active { get; set; }
        //
        public Address[] @addresses { get; set; }
        //
        public Email[] @emails { get; set; }
        // external unique resource id defined by provisioning client
        public string @externalId { get; set; }
        // unique resource id defined by RingCentral
        public string @id { get; set; }
        //
        public Name @name { get; set; }
        //
        public PhoneNumber[] @phoneNumbers { get; set; }
        //
        public Photo[] @photos { get; set; }
        //
        public string[] @schemas { get; set; }
        //
        //public EnterpriseUser @urn:ietf:params:scim:schemas:extension:enterprise:2.0:User { get; set; }
        // MUST be same as work type email address
        public string @userName { get; set; }
        //
        public Meta @meta { get; set; }
    }
}
