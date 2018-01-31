namespace RingCentral
{
    public partial class GetPresenceInfo
    {
        // Canonical URI of a presence info resource
        public string @uri { get; set; }
        // If 'True' enables other extensions to see the extension presence status
        public bool? @allowSeeMyPresence { get; set; }
        // Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.
        public string @dndStatus { get; set; }
        // Information on extension, for which this presence data is returned
        public GetPresenceExtensionInfo @extension { get; set; }
        // Custom status message (as previously published by user)
        public string @message { get; set; }
        // If 'True' enables the extension user to pick up a monitored line on hold
        public bool? @pickUpCallsOnHold { get; set; }
        // Aggregated presence status, calculated from a number of sources
        public string @presenceStatus { get; set; }
        // If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
        public bool? @ringOnMonitoredCall { get; set; }
        // Telephony presence status
        public string @telephonyStatus { get; set; }
        // User-defined presence status (as previously published by the user)
        public string @userStatus { get; set; }
        // Information on active calls
        public ActiveCallInfo[] @activeCalls { get; set; }
    }
}
