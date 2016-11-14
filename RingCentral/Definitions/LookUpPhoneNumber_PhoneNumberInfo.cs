namespace RingCentral
{
    public partial class LookUpPhoneNumber_PhoneNumberInfo
    {
        // Phone number in E.164 format without a '+'
        public string @phoneNumber { get; set; }
        // Phone number formatted according to current brand's default country
        public string @formattedNumber { get; set; }
        // Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern
        public string @vanityPattern { get; set; }
        // The value is returned if the extendedSearch parameter is true. '10' is the closest match
        public long? @rank { get; set; }
    }
}
