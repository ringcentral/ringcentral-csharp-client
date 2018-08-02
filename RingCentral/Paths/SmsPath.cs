using System.Threading.Tasks;
namespace RingCentral
{
    public partial class SmsPath : PathSegment
    {
        internal SmsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "sms";
            }
        }
        // Creates and sends new SMS message. Sending SMS messages simultaneously to different recipients is limited up to 50 requests per minute; relevant for all client applications.
        public Task<GetMessageInfoResponse> Post()
        {
            return RC.Post<GetMessageInfoResponse>(Endpoint(true), null);
        }
        // Creates and sends new SMS message. Sending SMS messages simultaneously to different recipients is limited up to 50 requests per minute; relevant for all client applications.
        public Task<GetMessageInfoResponse> Post(object parameters)
        {
            return RC.Post<GetMessageInfoResponse>(Endpoint(true), parameters);
        }
        // Creates and sends new SMS message. Sending SMS messages simultaneously to different recipients is limited up to 50 requests per minute; relevant for all client applications.
        public Task<GetMessageInfoResponse> Post(CreateSMSMessage parameters)
        {
            return Post(parameters as object);
        }
    }
}
