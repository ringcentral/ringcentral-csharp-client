namespace RingCentral
{
    public partial class UserCallLogRecord
    {
        // Internal identifier of a cal log record
        public string @id { get; set; }
        // Canonical URI of a call log record
        public string @uri { get; set; }
        // Internal identifier of a call session
        public string @sessionId { get; set; }
        //
        public CallLogCallerInfo @from { get; set; }
        //
        public CallLogCallerInfo @to { get; set; }
        // Call type = ['Voice', 'Fax']
        public string @type { get; set; }
        // Call direction
        public string @direction { get; set; }
        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @startTime { get; set; }
        // Call duration in seconds
        public long? @duration { get; set; }
        //
        public RecordingInfo @recording { get; set; }
    }
}
