using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ReservePath : Model
    {
        internal ReservePath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "reserve";
            }
        }
        // Reserve Phone Number
        public Task<PostResponse> Post()
        {
            return RC.Post<PostResponse>(Endpoint(true), null);
        }
        // Reserve Phone Number
        public Task<PostResponse> Post(object parameters)
        {
            return RC.Post<PostResponse>(Endpoint(true), parameters);
        }
        // Reserve Phone Number
        public Task<PostResponse> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Phone numbers to be reserved/un-reserved
            public ReservePhoneNumber_Request_ReserveRecord[] @records { get; set; }
        }
        public partial class PostResponse
        {
            // Phone numbers to be reserved/un-reserved
            public ReservePhoneNumber_Response_ReserveRecord[] @records { get; set; }
        }
    }
}
