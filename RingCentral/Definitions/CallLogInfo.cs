namespace RingCentral
{
    public partial class CallLogInfo
    {
        // Internal identifier of a cal log record
        public string @id { get; set; }
        // Canonical URI of a call log record
        public string @uri { get; set; }
        // Internal identifier of a call session
        public string @sessionId { get; set; }
        // Caller information
        public CallerInfo @from { get; set; }
        // Callee information
        public CallerInfo @to { get; set; }
        // Call type
        public string @type { get; set; }
        // Call direction
        public string @direction { get; set; }
        // Action description of the call operation
        public string @action { get; set; }
        // Status description of the call operation
        public string @result { get; set; }
        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @startTime { get; set; }
        // Call duration in seconds
        public long? @duration { get; set; }
        // Call recording data. Returned if the call is recorded
        public RecordingInfo @recording { get; set; }
    }
}
