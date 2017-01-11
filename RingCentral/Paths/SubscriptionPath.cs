using System.Threading.Tasks;
namespace RingCentral
{
    public partial class SubscriptionPath : PathSegment
    {
        internal SubscriptionPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "subscription";
            }
        }
        // Create New Subscription
        public Task<SubscriptionInfo> Post()
        {
            return RC.Post<SubscriptionInfo>(Endpoint(true), null);
        }
        // Create New Subscription
        public Task<SubscriptionInfo> Post(object parameters)
        {
            return RC.Post<SubscriptionInfo>(Endpoint(true), parameters);
        }
        // Create New Subscription
        public Task<SubscriptionInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Mandatory. Collection of URIs to API resources (see Event Types for details). For APNS transport type only message event filter is available
            public string[] @eventFilters { get; set; }
            // Notification delivery settings
            public Subscription_Request_DeliveryMode @deliveryMode { get; set; }
        }
        // Get Subscription List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        public partial class ListResponse
        {
            // Canonical URI of a subscription resource
            public string @uri { get; set; }
            // List of subscriptions for the current user and application
            public SubscriptionInfo[] @records { get; set; }
        }
        // Cancel Subscription by ID
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Get Subscription by ID
        public Task<SubscriptionInfo> Get()
        {
            return RC.Get<SubscriptionInfo>(Endpoint(true), null);
        }
        // Update/Renew Subscription by ID
        public Task<SubscriptionInfo> Put()
        {
            return RC.Put<SubscriptionInfo>(Endpoint(true), null);
        }
        // Update/Renew Subscription by ID
        public Task<SubscriptionInfo> Put(object parameters)
        {
            return RC.Put<SubscriptionInfo>(Endpoint(true), parameters);
        }
        // Update/Renew Subscription by ID
        public Task<SubscriptionInfo> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // Collection of URIs to API resources (see Event Types). Mandatory field
            public string[] @eventFilters { get; set; }
        }
    }
}
