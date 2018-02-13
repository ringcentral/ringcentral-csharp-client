namespace RingCentral
{
    public partial class ExtensionPresenceLineEvent
    {
        // Extension information
        public ExtensionNotificationInfo @extension { get; set; }
        // Order number of a notification to state the chronology
        public long? @sequence { get; set; }
    }
}
