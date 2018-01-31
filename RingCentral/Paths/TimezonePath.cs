using System.Threading.Tasks;
namespace RingCentral
{
    public partial class TimezonePath : PathSegment
    {
        internal TimezonePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "timezone";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all available timezones.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetTimezoneListResponse> List()
        {
            return RC.Get<GetTimezoneListResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all available timezones.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetTimezoneListResponse> List(object parameters)
        {
            return RC.Get<GetTimezoneListResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns all available timezones.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetTimezoneListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public string @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public string @perPage { get; set; }
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns the information on a certain timezone.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetTimezoneInfoResponse> Get()
        {
            return RC.Get<GetTimezoneInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns the information on a certain timezone.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetTimezoneInfoResponse> Get(object parameters)
        {
            return RC.Get<GetTimezoneInfoResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Returns the information on a certain timezone.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetTimezoneInfoResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
    }
}
