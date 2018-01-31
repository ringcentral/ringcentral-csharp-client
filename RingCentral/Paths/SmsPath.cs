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
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Creates and sends new SMS message. Sending SMS messages simultaneously to different recipients is limited up to 50 requests per minute; relevant for all client applications.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>SMS</td><td>Sending and receiving SMS (text) messages</td></tr><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetMessageInfoResponse> Post()
        {
            return RC.Post<GetMessageInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Creates and sends new SMS message. Sending SMS messages simultaneously to different recipients is limited up to 50 requests per minute; relevant for all client applications.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>SMS</td><td>Sending and receiving SMS (text) messages</td></tr><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetMessageInfoResponse> Post(object parameters)
        {
            return RC.Post<GetMessageInfoResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Creates and sends new SMS message. Sending SMS messages simultaneously to different recipients is limited up to 50 requests per minute; relevant for all client applications.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>SMS</td><td>Sending and receiving SMS (text) messages</td></tr><tr><td class='code'>ReadMessages</td><td>Viewing user messages</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetMessageInfoResponse> Post(CreateSMSMessage parameters)
        {
            return Post(parameters as object);
        }
    }
}
