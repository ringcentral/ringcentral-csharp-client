
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Order : Model
    {
        internal Order(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "order";
            }
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public partial class PostRequest
        {
            // List of devices to order
            public DeviceInfo[] devices { get; set; }
        }
        public partial class PostResponse
        {
            // List of the ordered devices
            public DeviceInfo[] devices { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Identifier of a device
            public string id { get; set; }
            // Canonical URI of an order resource
            public string uri { get; set; }
            // List of the ordered devices
            public DeviceInfo[] devices { get; set; }
        }
    }
}
