using System.Threading.Tasks;
namespace RingCentral
{
    public partial class SipProvisionPath : PathSegment
    {
        internal SipProvisionPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "sip-provision";
            }
        }
        // Creates SIP registration of a device/application (WebPhone, Mobile, softphone)
        public Task<CreateSipRegistrationResponse> Post()
        {
            return RC.Post<CreateSipRegistrationResponse>(Endpoint(true), null);
        }
        // Creates SIP registration of a device/application (WebPhone, Mobile, softphone)
        public Task<CreateSipRegistrationResponse> Post(object parameters)
        {
            return RC.Post<CreateSipRegistrationResponse>(Endpoint(true), parameters);
        }
        // Creates SIP registration of a device/application (WebPhone, Mobile, softphone)
        public Task<CreateSipRegistrationResponse> Post(CreateSipRegistrationRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
