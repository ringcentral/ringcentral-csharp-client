namespace RingCentral
{
    public partial class CallLogRecord
    {
        // Internal identifier of a cal log record
        public string @id { get; set; }
        // Canonical URI of a call log record
        public string @uri { get; set; }
        // Internal identifier of a call session
        public string @sessionId { get; set; }
        // Caller information
        public CallLogCallerInfo @from { get; set; }
        // Callee information
        public CallLogCallerInfo @to { get; set; }
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
        // Call recording data. Returned if the call is recorded, the withRecording parameter is set to 'True' in this case
        public RecordingInfo @recording { get; set; }
        // For 'Detailed' view only. The datetime when the call log record was modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @lastModifiedTime { get; set; }
        // For 'Detailed' view only. Call transport
        public string @transport { get; set; }
        // Information about extension on whose behalf a call is initiated. For Secretary call log the Boss extension info is returned
        public ActiveCallsRecordExtensionInfo @extension { get; set; }
        // Information on a delegate extension that actually implemented a call action. For Secretary call log the field is returned if the current extension implemented a call. For Boss call log the field contains information on a Secretary extension which actually implemented a call on behalf of the current extension
        public DelegateInfo @delegate { get; set; }
        // For 'Detailed' view only. Leg description
        public CallLogRecordLegInfo[] @legs { get; set; }
        //
        public CallLogRecordMessage @message { get; set; }
        // Returned only if this call was deleted. Value is set to 'True' in this case
        public bool? @deleted { get; set; }
    }
}
