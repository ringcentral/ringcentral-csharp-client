using System.Threading.Tasks;
namespace RingCentral
{
    public partial class WebhooksPath : PathSegment
    {
        internal WebhooksPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "webhooks";
            }
        }
        public ActivatePath Activate()
        {
            return new ActivatePath(this);
        }
        public SuspendPath Suspend()
        {
            return new SuspendPath(this);
        }
        // Create new Webhook
        public Task<GlipWebhookInfo> Post()
        {
            return RC.Post<GlipWebhookInfo>(Endpoint(true), null);
        }
        // Returns webhooks which are available for the current user (by group ID).
        public Task<GlipWebhookList> List()
        {
            return RC.Get<GlipWebhookList>(Endpoint(false), null);
        }
        // Deletes the webhook by ID.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
