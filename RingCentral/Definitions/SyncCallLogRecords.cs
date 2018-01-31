namespace RingCentral
{
    public partial class SyncCallLogRecords
    {
        //
        public string @uri { get; set; }
        //
        public CallLogRecordResource[] @records { get; set; }
        //
        public SyncInfo @syncInfo { get; set; }
    }
}
