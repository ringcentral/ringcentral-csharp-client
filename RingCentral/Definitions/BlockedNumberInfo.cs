namespace RingCentral
{
    public partial class BlockedNumberInfo
    {
        // Internal identifier of a blocked number
        public string @id { get; set; }
        // Canonical URI of a blocked number
        public string @uri { get; set; }
        // Name assigned by a user to a blocked phone number
        public string @name { get; set; }
        // Phone number to be blocked
        public string @phoneNumber { get; set; }
    }
}
