
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallLog : Model
    {
        internal CallLog(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "call-log";
            }
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public partial class ListQueryParams
        {
            // Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter
            public string extensionNumber { get; set; }
            // Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter
            public string phoneNumber { get; set; }
            // The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
            public string direction { get; set; }
            // Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
            public string type { get; set; }
            // The default value is 'Simple' for both account and extension call log
            public string view { get; set; }
            // 'True' if only recorded calls have to be returned
            public bool? withRecording { get; set; }
            // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string dateFrom { get; set; }
            // The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string dateTo { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. The default value is '1'
            public int? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default.
            public int? perPage { get; set; }
        }
        public partial class ListResponse
        {
            // List of call log records
            public CallLogRecord[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of a cal log record
            public string id { get; set; }
            // Canonical URI of a call log record
            public string uri { get; set; }
            // Internal identifier of a call session
            public string sessionId { get; set; }
            // Caller information
            public CallerInfo from { get; set; }
            // Callee information
            public CallerInfo to { get; set; }
            // Call type
            public string type { get; set; }
            // Call direction
            public string direction { get; set; }
            // Action description of the call operation
            public string action { get; set; }
            // Status description of the call operation
            public string result { get; set; }
            // The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string startTime { get; set; }
            // Call duration in seconds
            public int? duration { get; set; }
            // Call recording data. Returned if the call is recorded
            public RecordingInfo recording { get; set; }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete(object queryParams)
        {
            return RC.Delete(Endpoint(false), queryParams);
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete(DeleteQueryParams queryParams = null)
        {
            return Delete(queryParams as object);
        }
        public partial class DeleteQueryParams
        {
            // The end datetime for records deletion in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string dateTo { get; set; }
        }
    }
}
