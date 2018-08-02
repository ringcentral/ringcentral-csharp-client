namespace RingCentral
{
    public partial class ContactResource
    {
        //
        public AccountResource @account { get; set; }
        //
        public string @department { get; set; }
        //
        public string @email { get; set; }
        //
        public string @extensionNumber { get; set; }
        //
        public string @firstName { get; set; }
        //
        public string @id { get; set; }
        //
        public string @lastName { get; set; }
        //
        public string @jobTitle { get; set; }
        //
        public PhoneNumberResource[] @phoneNumbers { get; set; }
        //
        public AccountDirectoryProfileImageResource @profileImage { get; set; }
        //
        public BusinessSiteResource @site { get; set; }
        //
        public string @status { get; set; }
        //
        public string @type { get; set; }
    }
}
