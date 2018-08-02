using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RenewPath : PathSegment
    {
        internal RenewPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "renew";
            }
        }
        // Renews an existent subscription by ID by posting request with an empty body.
        public Task<SubscriptionInfo> Post()
        {
            return RC.Post<SubscriptionInfo>(Endpoint(true), null);
        }
    }
}
