using System.Threading.Tasks;
namespace RingCentral
{
    public partial class OrderPath : Model
    {
        internal OrderPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "order";
            }
        }
        // Create New Order
        public Task<PostResponse> Post()
        {
            return RC.Post<PostResponse>(Endpoint(true), null);
        }
        // Create New Order
        public Task<PostResponse> Post(object parameters)
        {
            return RC.Post<PostResponse>(Endpoint(true), parameters);
        }
        // Create New Order
        public Task<PostResponse> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // List of devices to order
            public DeviceInfo[] @devices { get; set; }
        }
        public partial class PostResponse
        {
            // List of the ordered devices
            public DeviceInfo[] @devices { get; set; }
        }
        // Get Order by ID
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Identifier of a device
            public string @id { get; set; }
            // Canonical URI of an order resource
            public string @uri { get; set; }
            // List of the ordered devices
            public DeviceInfo[] @devices { get; set; }
        }
    }
}
