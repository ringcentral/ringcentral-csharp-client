namespace RingCentral
{
    public partial class PresenceLineEvent
    {
        // Extension information
        public PresenceLineEvent_ExtensionInfo @extension { get; set; }
        // Order number of a notification to state the chronology
        public long? @sequence { get; set; }
    }
}
