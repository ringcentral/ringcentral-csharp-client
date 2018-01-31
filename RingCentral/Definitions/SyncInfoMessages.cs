namespace RingCentral
{
    public partial class SyncInfoMessages
    {
        // Type of synchronization
        public string @syncType { get; set; }
        // Synchronization token
        public string @syncToken { get; set; }
        // Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @syncTime { get; set; }
    }
}
