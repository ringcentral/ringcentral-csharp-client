using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ActivatePath : PathSegment
    {
        internal ActivatePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "activate";
            }
        }
        // Activates webhooks by ID.
        public Task<GlipWebhookInfo> Post()
        {
            return RC.Post<GlipWebhookInfo>(Endpoint(true), null);
        }
    }
}
