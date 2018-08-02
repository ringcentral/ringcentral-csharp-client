using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CompanyPagerPath : PathSegment
    {
        internal CompanyPagerPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "company-pager";
            }
        }
        // Creates and sends an internal text message.
        public Task<GetMessageInfoResponse> Post()
        {
            return RC.Post<GetMessageInfoResponse>(Endpoint(true), null);
        }
        // Creates and sends an internal text message.
        public Task<GetMessageInfoResponse> Post(object parameters)
        {
            return RC.Post<GetMessageInfoResponse>(Endpoint(true), parameters);
        }
        // Creates and sends an internal text message.
        public Task<GetMessageInfoResponse> Post(CreateInternalTextMessageRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
