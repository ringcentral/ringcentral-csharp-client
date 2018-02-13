namespace RingCentral
{
    public partial class UserUpdateRequest
    {
        // Status of a user
        public bool? @active { get; set; }
        // User addresses
        public AddressInfo[] @addresses { get; set; }
        // User email addresses
        public EmailInfo[] @emails { get; set; }
        // External identifier of a user
        public string @externalId { get; set; }
        // Internal identifier of a user
        public string @id { get; set; }
        // User name
        public NameInfo @name { get; set; }
        // User phone numbers
        public PhoneNumberInfoRequest[] @phoneNumbers { get; set; }
        //
        public PhotoInfo[] @photos { get; set; }
        // Specification links
        public string[] @schemas { get; set; }
        //
        //public EnterpriseUser @urn:ietf:params:scim:schemas:extension:enterprise:2.0:User { get; set; }
        // User mailbox. Must be same as work type email address
        public string @userName { get; set; }
    }
}
