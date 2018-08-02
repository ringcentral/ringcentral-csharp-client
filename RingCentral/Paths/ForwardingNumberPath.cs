using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ForwardingNumberPath : PathSegment
    {
        internal ForwardingNumberPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "forwarding-number";
            }
        }
        // Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers used for call forwarding and call flip.
        public Task<GetExtensionForwardingNumberListResponse> List()
        {
            return RC.Get<GetExtensionForwardingNumberListResponse>(Endpoint(false), null);
        }
        // Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers used for call forwarding and call flip.
        public Task<GetExtensionForwardingNumberListResponse> List(object parameters)
        {
            return RC.Get<GetExtensionForwardingNumberListResponse>(Endpoint(false), parameters);
        }
        // Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers used for call forwarding and call flip.
        public Task<GetExtensionForwardingNumberListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are accepted.
            public long? @page { get; set; }
            // Indicates the page size (number of items).
            public long? @perPage { get; set; }
        }
        // Adds a new forwarding number to the forwarding number list.
        public Task<ForwardingNumberInfo> Post()
        {
            return RC.Post<ForwardingNumberInfo>(Endpoint(true), null);
        }
        // Adds a new forwarding number to the forwarding number list.
        public Task<ForwardingNumberInfo> Post(object parameters)
        {
            return RC.Post<ForwardingNumberInfo>(Endpoint(true), parameters);
        }
        // Adds a new forwarding number to the forwarding number list.
        public Task<ForwardingNumberInfo> Post(CreateForwardingNumberRequest parameters)
        {
            return Post(parameters as object);
        }
        // Returns a specific forwarding number.
        public Task<ForwardingNumberResource> Get()
        {
            return RC.Get<ForwardingNumberResource>(Endpoint(true), null);
        }
        // Updates the existing forwarding number from the forwarding number list.
        public Task<ForwardingNumberInfo> Put()
        {
            return RC.Put<ForwardingNumberInfo>(Endpoint(true), null);
        }
        // Updates the existing forwarding number from the forwarding number list.
        public Task<ForwardingNumberInfo> Put(object parameters)
        {
            return RC.Put<ForwardingNumberInfo>(Endpoint(true), parameters);
        }
        // Updates the existing forwarding number from the forwarding number list.
        public Task<ForwardingNumberInfo> Put(UpdateForwardingNumberRequest parameters)
        {
            return Put(parameters as object);
        }
        // Deletes a forwarding number from the forwarding number list by its ID.
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
