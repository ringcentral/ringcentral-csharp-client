namespace RingCentral
{
    public partial class CompanyDirectoryPhoneNumberInfo
    {
        // Extension phone number in E.164 format
        public string @phoneNumber { get; set; }
        // Type of a phone number
        public string @type { get; set; }
        // Specifies if a phone number should be hidden or not. Returned only if the value is 'True'
        public bool? @hidden { get; set; }
        // Usage type of a phone number
        public string @usageType { get; set; }
    }
}
