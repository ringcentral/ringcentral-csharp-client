namespace RingCentral
{
    public partial class BlockedNumberInfo
    {
        // Standard resource properties ID and canonical URI, see the section called “Resource Identification Properties”
        public string @id { get; set; }
        // Canonical URI of a blocked number resource
        public string @uri { get; set; }
        // Name assigned by a user to a blocked phone number
        public string @name { get; set; }
        // Phone number to be blocked
        public string @phoneNumber { get; set; }
    }
}
