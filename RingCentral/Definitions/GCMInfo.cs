namespace RingCentral
{
    public partial class GCMInfo
    {
        // Notification priority, if the value is 'high' then notification is turned on even if the application is in background
        public string @priority { get; set; }
        // Notification lifetime value in seconds, the default value is 30 seconds
        public long? @time_to_live { get; set; }
        // GCM data
        public GCMData @data { get; set; }
    }
}
