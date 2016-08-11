
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BusinessHours : Model
    {
        internal BusinessHours(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "business-hours";
            }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public partial class GetResponse
        {
            // Canonical URI of a business-hours resource
            public string uri { get; set; }
            // Schedule when an answering rule is applied
            public BusinessHour_ScheduleInfo schedule { get; set; }
        }
    }
}
