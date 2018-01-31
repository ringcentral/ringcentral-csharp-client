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
        //
        public Task<MeetingServiceInfoResource> Get()
        {
            return RC.Get<MeetingServiceInfoResource>(Endpoint(true), null);
        }
    }
}
