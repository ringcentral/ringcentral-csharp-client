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
        // Returns all available timezones.
        public Task<GetTimezoneListResponse> List()
        {
            return RC.Get<GetTimezoneListResponse>(Endpoint(false), null);
        }
        // Returns all available timezones.
        public Task<GetTimezoneListResponse> List(object parameters)
        {
            return RC.Get<GetTimezoneListResponse>(Endpoint(false), parameters);
        }
        // Returns all available timezones.
        public Task<GetTimezoneListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public string @page { get; set; }
            // Indicates the page size (number of items)
            public string @perPage { get; set; }
        }
        // Returns the information on a certain timezone.
        public Task<GetTimezoneInfoResponse> Get()
        {
            return RC.Get<GetTimezoneInfoResponse>(Endpoint(true), null);
        }
        // Returns the information on a certain timezone.
        public Task<GetTimezoneInfoResponse> Get(object parameters)
        {
            return RC.Get<GetTimezoneInfoResponse>(Endpoint(true), parameters);
        }
        // Returns the information on a certain timezone.
        public Task<GetTimezoneInfoResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted
            public string @page { get; set; }
            // Indicates the page size (number of items)
            public string @perPage { get; set; }
        }
    }
}
