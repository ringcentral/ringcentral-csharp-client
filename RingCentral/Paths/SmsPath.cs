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
        // Create and Send SMS Message
        public Task<MessageInfo> Post()
        {
            return RC.Post<MessageInfo>(Endpoint(true), null);
        }
        // Create and Send SMS Message
        public Task<MessageInfo> Post(object parameters)
        {
            return RC.Post<MessageInfo>(Endpoint(true), parameters);
        }
        // Create and Send SMS Message
        public Task<MessageInfo> Post(PostParameters parameters)
        {
            return Post(parameters as object);
        }
        public partial class PostParameters
        {
            // Sender of an SMS message. The phoneNumber property must be filled to correspond to one of the account phone numbers which is allowed to send SMS
            public CallerInfo @from { get; set; }
            // Receiver of an SMS message. The phoneNumber property must be filled
            public CallerInfo[] @to { get; set; }
            // Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols
            public string @text { get; set; }
        }
    }
}
