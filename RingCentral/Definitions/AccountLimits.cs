namespace RingCentral
{
    public partial class AccountLimits
    {
        // Max number of free softphone phone lines per user extension
        public long? @freeSoftPhoneLinesPerExtension { get; set; }
        // Max number of participants in RingCentral Meeting hosted by this account's user
        public long? @meetingSize { get; set; }
        // Max number of extensions which can be included in the list of users monitored for Presence
        public long? @maxMonitoredExtensionsPerUser { get; set; }
        // Max length of extension numbers of an account; depends on account type
        public long? @maxExtensionNumberLength { get; set; }
        // Length of a site code
        public long? @siteCodeLength { get; set; }
        // Length of a short extension number
        public long? @shortExtensionNumberLength { get; set; }
    }
}
