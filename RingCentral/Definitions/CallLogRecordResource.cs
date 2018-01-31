namespace RingCentral
{
    public partial class CallLogRecordResource
    {
        //
        public string @uri { get; set; }
        //
        public string @id { get; set; }
        //
        public string @sessionId { get; set; }
        //
        public string @startTime { get; set; }
        //
        public long? @duration { get; set; }
        //
        public string @type { get; set; }
        //
        public string @direction { get; set; }
        //
        public string @action { get; set; }
        //
        public string @result { get; set; }
        //
        public CallerInfo @to { get; set; }
        //
        public CallerInfo @from { get; set; }
        //
        public CallLogRecordingResource @recording { get; set; }
    }
}
