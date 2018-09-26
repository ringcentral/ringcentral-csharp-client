using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallLogPath : PathSegment
    {
        internal CallLogPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "call-log";
            }
        }
        // Returns call log records filtered by parameters specified.
        public Task<ExtensionCallLogResponse> List()
        {
            return RC.Get<ExtensionCallLogResponse>(Endpoint(false), null);
        }
        // Returns call log records filtered by parameters specified.
        public Task<ExtensionCallLogResponse> List(object parameters)
        {
            return RC.Get<ExtensionCallLogResponse>(Endpoint(false), parameters);
        }
        // Returns call log records filtered by parameters specified.
        public Task<ExtensionCallLogResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Extension number of a user. If specified, returns call log for a particular extension only
            public string @extensionNumber { get; set; }
            // If 'True' then calls from/to blocked numbers are returned
            public bool? @showBlocked { get; set; }
            // Phone number of a caller/callee. If specified, returns all calls (both incoming and outcoming) with the phone number specified
            public string @phoneNumber { get; set; }
            // The direction for the resulting records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
            public string[] @direction { get; set; }
            // Internal identifier of a session
            public string @sessionId { get; set; }
            // Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
            public string[] @type { get; set; }
            // Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled
            public string[] @transport { get; set; }
            // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
            public string @view { get; set; }
            // True should be specified to return recorded calls only
            public bool? @withRecording { get; set; }
            // The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string @dateFrom { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // If 'True' then deleted calls are returned
            public bool? @showDeleted { get; set; }
        }
        // Deletes filtered call log records.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Deletes filtered call log records.
        public async Task<bool> Delete(object parameters)
        {
            await RC.Delete(Endpoint(true), parameters);
            return true;
        }
        // Deletes filtered call log records.
        public Task<bool> Delete(DeleteParameters parameters)
        {
            return Delete(parameters as object);
        }
        public partial class DeleteParameters
        {
            // The end datetime for records deletion in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            //
            public string @phoneNumber { get; set; }
            //
            public string @extensionNumber { get; set; }
            //
            public string[] @type { get; set; }
            //
            public string[] @direction { get; set; }
            //
            public string @dateFrom { get; set; }
        }
        // Returns call log records by ID.
        public Task<UserCallLogRecord> Get()
        {
            return RC.Get<UserCallLogRecord>(Endpoint(true), null);
        }
        // Returns call log records by ID.
        public Task<UserCallLogRecord> Get(object parameters)
        {
            return RC.Get<UserCallLogRecord>(Endpoint(true), parameters);
        }
        // Returns call log records by ID.
        public Task<UserCallLogRecord> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
            public string @view { get; set; }
        }
    }
}
