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
        // <p style='font-style:italic;'>Since 1.0.3 (Release 5.11)</p><p>Returns call log records filtered by the specified parameters.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<ExtensionCallLogResponse> List()
        {
            return RC.Get<ExtensionCallLogResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.3 (Release 5.11)</p><p>Returns call log records filtered by the specified parameters.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<ExtensionCallLogResponse> List(object parameters)
        {
            return RC.Get<ExtensionCallLogResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.3 (Release 5.11)</p><p>Returns call log records filtered by the specified parameters.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<ExtensionCallLogResponse> List(ListParameters parameters)
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
            // The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
            public string[] @direction { get; set; }
            //
            public string @sessionId { get; set; }
            // Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
            public string[] @type { get; set; }
            // Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled
            public string[] @transport { get; set; }
            // The default value is 'Simple' for both account and extension call log
            public string[] @view { get; set; }
            // 'True' if only recorded calls have to be returned
            public bool? @withRecording { get; set; }
            // The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string @dateTo { get; set; }
            // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string @dateFrom { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditCallLog</td><td>Viewing and updating user call logs</td></tr><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditCallLog</td><td>Viewing and updating user call logs</td></tr><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public async Task<bool> Delete(object parameters)
        {
            await RC.Delete(Endpoint(true), parameters);
            return true;
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditCallLog</td><td>Viewing and updating user call logs</td></tr><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
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
        //
        public Task<UserCallLogRecord> Get()
        {
            return RC.Get<UserCallLogRecord>(Endpoint(true), null);
        }
        //
        public Task<UserCallLogRecord> Get(object parameters)
        {
            return RC.Get<UserCallLogRecord>(Endpoint(true), parameters);
        }
        //
        public Task<UserCallLogRecord> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            //
            public string @view { get; set; }
        }
    }
}
