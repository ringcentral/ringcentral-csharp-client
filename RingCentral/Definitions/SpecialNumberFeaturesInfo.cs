namespace RingCentral
{
    public partial class SpecialNumberFeaturesInfo
    {
        // VoIP call
        public OptionInfo @voip { get; set; }
        // RingOut call
        public OptionInfo @ringOut { get; set; }
        // Outgoing SMS
        public OptionInfo @sms { get; set; }
        // Outgoing Fax
        public OptionInfo @faxOut { get; set; }
    }
}
