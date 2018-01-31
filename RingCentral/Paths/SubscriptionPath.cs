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
        public RenewPath Renew()
        {
            return new RenewPath(this);
        }
        //
        public Task<RecordsCollectionResourceSubscriptionResponse> List()
        {
            return RC.Get<RecordsCollectionResourceSubscriptionResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.6 (Release 5.15)</p><p>Creates a new subscription.</p><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<SubscriptionInfo> Post()
        {
            return RC.Post<SubscriptionInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.6 (Release 5.15)</p><p>Creates a new subscription.</p><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<SubscriptionInfo> Post(object parameters)
        {
            return RC.Post<SubscriptionInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.6 (Release 5.15)</p><p>Creates a new subscription.</p><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<SubscriptionInfo> Post(CreateSubscriptionRequest parameters)
        {
            return Post(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.6 (Release 5.15)</p><p>Returns the requested subscription.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<SubscriptionInfo> Get()
        {
            return RC.Get<SubscriptionInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.6 (Release 5.15)</p><p>Renews the existent subscription if the request body is empty. If event filters are specified, calling this method modifies the event filters for the existing subscription. The client application can extend or narrow the events for which it receives notifications in the frame of one subscription.</p><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<SubscriptionInfo> Put()
        {
            return RC.Put<SubscriptionInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.6 (Release 5.15)</p><p>Renews the existent subscription if the request body is empty. If event filters are specified, calling this method modifies the event filters for the existing subscription. The client application can extend or narrow the events for which it receives notifications in the frame of one subscription.</p><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<SubscriptionInfo> Put(object parameters)
        {
            return RC.Put<SubscriptionInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.6 (Release 5.15)</p><p>Renews the existent subscription if the request body is empty. If event filters are specified, calling this method modifies the event filters for the existing subscription. The client application can extend or narrow the events for which it receives notifications in the frame of one subscription.</p><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<SubscriptionInfo> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // If 'True' then aggregated presence status is returned in a notification payload
            public bool? @aggregated { get; set; }
        }
        // <p style='font-style:italic;'></p><p>Cancels the existent subscription.</p><h4>Usage Plan Group</h4><p>Medium</p>
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
