namespace RingCentral
{
    public partial class LookupPhoneNumberInfo
    {
        // Phone number in E.164 format
        public string @phoneNumber { get; set; }
        // Phone number formatted according to current brand's default country
        public string @formattedNumber { get; set; }
        // Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern
        public string @vanityPattern { get; set; }
        // The value is returned if the extendedSearch parameter is true. The values are 10, 9, 8, etc.; '10' is the closest match
        public long? @rank { get; set; }
    }
}
