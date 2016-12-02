using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BusinessHoursPath : PathSegment
    {
        internal BusinessHoursPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "business-hours";
            }
        }
        // Get User Hours Setting
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Canonical URI of a business-hours resource
            public string @uri { get; set; }
            // Schedule when an answering rule is applied
            public BusinessHour_ScheduleInfo @schedule { get; set; }
        }
    }
}
