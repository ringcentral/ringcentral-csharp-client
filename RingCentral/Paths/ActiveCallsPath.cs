using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ActiveCallsPath : PathSegment
    {
        internal ActiveCallsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "active-calls";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.13 (Release 6.5)</p><p>Returns records of all extension calls that are in progress, ordered by start time in descending order.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<ExtensionActiveCallsResponse> List()
        {
            return RC.Get<ExtensionActiveCallsResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.13 (Release 6.5)</p><p>Returns records of all extension calls that are in progress, ordered by start time in descending order.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<ExtensionActiveCallsResponse> List(object parameters)
        {
            return RC.Get<ExtensionActiveCallsResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.13 (Release 6.5)</p><p>Returns records of all extension calls that are in progress, ordered by start time in descending order.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadCallLog</td><td>Viewing user call logs</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<ExtensionActiveCallsResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
            public string[] @direction { get; set; }
            // Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
            public string[] @type { get; set; }
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
    }
}
