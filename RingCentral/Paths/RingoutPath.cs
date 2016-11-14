using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RingoutPath : Model
    {
        internal RingoutPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "ringout";
            }
        }
        // Initiate RingOut Call
        public Task<RingOutInfo> Post()
        {
            return RC.Post<RingOutInfo>(Endpoint(true), null);
        }
        // Initiate RingOut Call
        public Task<RingOutInfo> Post(object parameters)
        {
            return RC.Post<RingOutInfo>(Endpoint(true), parameters);
        }
        // Initiate RingOut Call
        public Task<RingOutInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Phone number of the caller. This number corresponds to the 1st leg of the RingOut call. This number can be one of user's configured forwarding numbers or arbitrary number
            public RingOut_Request_From @from { get; set; }
            // Phone number of the called party. This number corresponds to the 2nd leg of the RingOut call
            public RingOut_Request_To @to { get; set; }
            // The number which will be displayed to the called party
            public RingOut_Request_To @callerId { get; set; }
            // The audio prompt that the calling party hears when the call is connected
            public bool? @playPrompt { get; set; }
            // Optional. Dialing plan country data. If not specified, then extension home country is applied by default
            public RingOut_Request_CountryInfo @country { get; set; }
        }
        // Cancel RingOut Call
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Get RingOut Call Status
        public Task<RingOutInfo> Get()
        {
            return RC.Get<RingOutInfo>(Endpoint(true), null);
        }
    }
}
