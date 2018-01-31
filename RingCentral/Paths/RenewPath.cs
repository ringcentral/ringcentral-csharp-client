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
        // <p style='font-style:italic;'>Since 1.0.26 (Release 8.12)</p><p>Renews an existent subscription by ID by posting request with an empty body..</p><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<SubscriptionInfo> Get()
        {
            return RC.Get<SubscriptionInfo>(Endpoint(true), null);
        }
    }
}
