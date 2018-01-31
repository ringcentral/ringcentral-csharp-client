namespace RingCentral
{
    public partial class AccountLimits
    {
        // The maximum number of free softphone phone lines per user extension
        public long? @freeSoftPhoneLinesPerExtension { get; set; }
        // The maximum number of participants in RingCentral Meeting hosted by this account's user
        public long? @meetingSize { get; set; }
        // The maximum number of extensions which can be included in the list of users monitored for Presence
        public long? @maxMonitoredExtensionsPerUser { get; set; }
        // Maximum length for extension numbers of an account; depends on account type. The default value is 5
        public long? @maxExtensionNumberLength { get; set; }
    }
}
