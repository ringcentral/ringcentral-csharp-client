namespace RingCentral
{
    public partial class DetailedExtensionPresenceEventBody
    {
        // Internal identifier of an extension
        public string @extensionId { get; set; }
        // Telephony presence status. Returned if telephony status is changed.
        public string @telephonyStatus { get; set; }
        // List of the latest 10 active calls on extension
        public ActiveCallInfoWithoutSIP[] @activeCalls { get; set; }
        // Order number of a notification to state the chronology
        public long? @sequence { get; set; }
        // Aggregated presence status, calculated from a number of sources
        public string @presenceStatus { get; set; }
        // User-defined presence status (as previously published by the user)
        public string @userStatus { get; set; }
        // Extended DnD (Do not Disturb) status
        public string @dndStatus { get; set; }
        // If 'True' enables other extensions to see the extension presence status
        public bool? @allowSeeMyPresence { get; set; }
        // If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
        public bool? @ringOnMonitoredCall { get; set; }
        // If 'True' enables the extension user to pick up a monitored line on hold
        public bool? @pickUpCallsOnHold { get; set; }
        // Total number of active calls on extension at the present moment
        public long? @totalActiveCalls { get; set; }
        // Internal identifier of a subscription owner extension
        public string @ownerId { get; set; }
    }
}
