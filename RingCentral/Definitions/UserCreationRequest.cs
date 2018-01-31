namespace RingCentral
{
    public partial class UserCreationRequest
    {
        // Specification links
        public string[] @schemas { get; set; }
        // User name
        public NameInfoRequest @name { get; set; }
        // User mailbox
        public string @userName { get; set; }
        // User email addresses
        public EmailInfoRequest[] @emails { get; set; }
        // User phone numbers
        public PhoneNumberInfoRequest[] @phoneNumbers { get; set; }
        // External identifier of a user
        public string @externalId { get; set; }
        // User addresses
        public AddressInfoRequest @addresses { get; set; }
        // Urn link
        // public UrnInfoRequest @urn:ietf:params:scim:schemas:extension:enterprise:2.0:User { get; set; }
    }
}
