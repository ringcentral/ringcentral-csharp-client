using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MeetingServiceInfoPath : PathSegment
    {
        internal MeetingServiceInfoPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "meeting/service-info";
            }
        }
        // Get Meeting Service Info
        public Task<MeetingServiceInfo> Get()
        {
            return RC.Get<MeetingServiceInfo>(Endpoint(true), null);
        }
    }
}
