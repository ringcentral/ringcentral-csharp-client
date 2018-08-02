using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BulkPurchasePath : PathSegment
    {
        internal BulkPurchasePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "bulk-purchase";
            }
        }
        // Purchases licenses for add-on features: Rooms, Room Connector, Webinar, Live Reports, etc.
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
        // Purchases licenses for add-on features: Rooms, Room Connector, Webinar, Live Reports, etc.
        public async Task<bool> Post(object parameters)
        {
            await RC.Post(Endpoint(true), parameters);
            return true;
        }
        // Purchases licenses for add-on features: Rooms, Room Connector, Webinar, Live Reports, etc.
        public Task<bool> Post(OrderLicensesRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
