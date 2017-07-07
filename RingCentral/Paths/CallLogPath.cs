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
        // Get Account Call Log
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Account Call Log
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Account Call Log
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter
            public string @extensionNumber { get; set; }
            // If 'True' then calls from/to blocked numbers are returned. The default value is 'True'
            public bool? @showBlocked { get; set; }
            // Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter
            public string @phoneNumber { get; set; }
            // The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are supported
            public string @direction { get; set; }
            // Internal identifier of a call session. Cannot be specified along with parameters 'dateTo'/'dateFrom'
            public string @sessionId { get; set; }
            // Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are supported
            public string @type { get; set; }
            // Call transport type. By default this filter is disabled
            public string @transport { get; set; }
            // The default value is 'Simple' for both account and extension call log
            public string @view { get; set; }
            // 'True' if only recorded calls are returned. The default value is 'False'
            public bool? @withRecording { get; set; }
            // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string @dateFrom { get; set; }
            // The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. The default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default.
            public long? @perPage { get; set; }
        }
        public partial class ListResponse
        {
            // Canonical URI
            public string @uri { get; set; }
            // List of call log records
            public CallLogRecord[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get Account Call Log Record by ID
        public Task<CallLogInfo> Get()
        {
            return RC.Get<CallLogInfo>(Endpoint(true), null);
        }
        // Delete Extension Call Log
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Delete Extension Call Log
        public async Task<bool> Delete(object parameters)
        {
            await RC.Delete(Endpoint(true), parameters);
            return true;
        }
        // Delete Extension Call Log
        public Task<bool> Delete(DeleteParameters parameters)
        {
            return Delete(parameters as object);
        }
        public partial class DeleteParameters
        {
            // The end datetime for records deletion in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
        }
    }
}
