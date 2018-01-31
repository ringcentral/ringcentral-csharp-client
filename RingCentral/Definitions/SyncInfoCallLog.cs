namespace RingCentral
{
    public partial class SyncInfoCallLog
    {
        // Type of synchronization
        public string @syncType { get; set; }
        // Synchronization token
        public string @syncToken { get; set; }
        // The last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @syncTime { get; set; }
    }
}
