namespace RingCentral
{
    public partial class FederationMainNumberInfo
    {
        // Main company number of an account in E.164 format
        public string @phoneNumber { get; set; }
        // Main company number of an account formatted as consistent with the home country of the current extension
        public string @formattedPhoneNumber { get; set; }
    }
}
