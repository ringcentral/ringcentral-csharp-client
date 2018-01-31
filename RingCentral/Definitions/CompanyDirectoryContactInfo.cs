namespace RingCentral
{
    public partial class CompanyDirectoryContactInfo
    {
        // Internal identifier of an extension
        public string @id { get; set; }
        // Type of an extension
        public string @type { get; set; }
        // Status of an extension
        public string @status { get; set; }
        // User extension first name
        public string @firstName { get; set; }
        // User extension last name
        public string @lastName { get; set; }
        // Name of an extension
        public string @name { get; set; }
        // Department name of an extension
        public string @department { get; set; }
        // Email of an extension
        public string @email { get; set; }
        // Number of an extension
        public string @extensionNumber { get; set; }
        // Account data of an extension
        public CompanyDirectoryAccountInfo @account { get; set; }
        // Extension phone numbers information
        public CompanyDirectoryPhoneNumberInfo[] @phoneNumbers { get; set; }
        // Extension profile image information. Not returned if profile images are absent for an extension
        public CompanyDirectoryProfileImageInfo @profileImage { get; set; }
    }
}
