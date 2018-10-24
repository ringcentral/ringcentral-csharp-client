namespace RingCentral
{
    public partial class CallLogRecordLegInfo
    {
        // Action description of the call operation
        public string @action { get; set; }
        // Call direction
        public string @direction { get; set; }
        // Call duration in seconds
        public long? @duration { get; set; }
        // Information on extension
        public ExtensionInfoCallLog @extension { get; set; }
        // Leg type
        public string @legType { get; set; }
        // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @startTime { get; set; }
        // Call type
        public string @type { get; set; }
        // Status description of the call operation
        public string @result { get; set; }
        // Caller information
        public CallLogCallerInfo @from { get; set; }
        // Callee information
        public CallLogCallerInfo @to { get; set; }
        // Call transport
        public string @transport { get; set; }
        // Call recording data. Returned if the call is recorded
        public RecordingInfo @recording { get; set; }
        //
        public bool? @master { get; set; }
    }
}
