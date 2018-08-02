using System.Threading.Tasks;
namespace RingCentral
{
    public partial class SuspendPath : PathSegment
    {
        internal SuspendPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "suspend";
            }
        }
        // Suspends webhooks by ID.
        public Task<GlipWebhookInfo> Post()
        {
            return RC.Post<GlipWebhookInfo>(Endpoint(true), null);
        }
    }
}
