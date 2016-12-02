using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PresencePath : PathSegment
    {
        internal PresencePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "presence";
            }
        }
        // Get Extension Presence
        public Task<PresenceInfo> Get()
        {
            return RC.Get<PresenceInfo>(Endpoint(true), null);
        }
    }
}
