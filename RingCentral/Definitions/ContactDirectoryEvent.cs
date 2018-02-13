namespace RingCentral
{
    public partial class ContactDirectoryEvent
    {
        // Internal identifier of an extension
        public string @id { get; set; }
        // Type of change
        public string @eventType { get; set; }
        // Extension Type
        public string @type { get; set; }
        // Status of an extension
        public string @status { get; set; }
        // First name of an extension user
        public string @firstName { get; set; }
        // Last name of an extension user
        public string @lastName { get; set; }
        // Department Name
        public string @department { get; set; }
        // Email of an extension user
        public string @email { get; set; }
        // Extension number
        public string @extensionNumber { get; set; }
        // Account data of an extension
        public CompanyDirectoryAccountInfo @account { get; set; }
        // Extension phone number information
        public CompanyDirectoryPhoneNumberInfo @phoneNumbers { get; set; }
        // Site Data
        public SiteInfo @site { get; set; }
        // Extension profile image information. Not returned if profile images are absent for an extension
        public CompanyDirectoryProfileImageInfo @profileImage { get; set; }
    }
}
