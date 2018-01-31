namespace RingCentral
{
    public partial class IVRMenuActionsInfo
    {
        // Key. The following values are supported: numeric: '1' to '9' Star Hash NoInput
        public string @input { get; set; }
        // Internal identifier of an answering rule
        public string @action { get; set; }
        // For 'Connect' or 'Voicemail' actions only. Extension reference
        public IVRMenuExtensionInfo @extension { get; set; }
        // For 'Transfer' action only. PSTN number in E.164 format
        public string @phoneNumber { get; set; }
    }
}
