namespace RingCentral
{
    public partial class SpecialNumberInfo
    {
        // Service phone number in N11 code format
        public string @phoneNumber { get; set; }
        // Description of a special number
        public string @description { get; set; }
        // Information on options allowed/disallowed for the special number
        public SpecialNumberFeaturesInfo @features { get; set; }
    }
}
