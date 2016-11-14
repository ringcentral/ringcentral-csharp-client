using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MeetingServiceInfoPath : Model
    {
        internal MeetingServiceInfoPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
