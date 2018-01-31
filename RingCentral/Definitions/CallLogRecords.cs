namespace RingCentral
{
    public partial class CallLogRecords
    {
        //
        public string @uri { get; set; }
        //
        public CallLogRecordResource[] @records { get; set; }
        //
        public Paging @paging { get; set; }
        //
        public Navigation @navigation { get; set; }
    }
}
