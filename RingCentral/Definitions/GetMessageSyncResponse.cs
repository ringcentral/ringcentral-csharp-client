namespace RingCentral
{
    public partial class GetMessageSyncResponse
    {
        // List of message records with synchronization information
        public GetMessageInfoResponse[] @records { get; set; }
        // Sync type, token and time
        public SyncInfoMessages @syncInfo { get; set; }
    }
}
