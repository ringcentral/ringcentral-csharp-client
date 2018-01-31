namespace RingCentral
{
    public partial class UserInfo
    {
        // Specification links
        public string[] @schemas { get; set; }
        // Internal identifier of a user
        public string @id { get; set; }
        // External identifier of a user
        public string @externalId { get; set; }
        // User metadata
        public MetaInfo @meta { get; set; }
        // User mailbox
        public string @userName { get; set; }
        // User name
        public NameInfo @name { get; set; }
        // Status of a user
        public bool? @active { get; set; }
        // User email addresses
        public EmailInfo[] @emails { get; set; }
        // User phone numbers
        public PhoneNumberInfo[] @phoneNumbers { get; set; }
        // User addresses
        public AddressInfo[] @addresses { get; set; }
    }
}
