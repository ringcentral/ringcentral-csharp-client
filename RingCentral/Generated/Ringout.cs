
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Ringout : Model
    {
        internal Ringout(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "ringout";
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
            // Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of user's configured forwarding numbers or arbitrary number
            public RingOut_Request_From from { get; set; }
            // Phone number of the called party. This number corresponds to the 2nd leg of the RingOut call
            public RingOut_Request_To to { get; set; }
            // The number which will be displayed to the called party
            public RingOut_Request_To callerId { get; set; }
            // The audio prompt that the calling party hears when the call is connected
            public bool? playPrompt { get; set; }
            // Optional. Dialing plan country data. If not specified, then extension home country is applied by default
            public RingOut_Request_CountryInfo country { get; set; }
        }
        public partial class PostResponse
        {
            // Internal identifier of a RingOut call
            public string id { get; set; }
            // RingOut status information
            public RingOutStatusInfo status { get; set; }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of a RingOut call
            public string id { get; set; }
            // RingOut status information
            public RingOutStatusInfo status { get; set; }
        }
    }
}
