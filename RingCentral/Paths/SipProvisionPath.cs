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
        // <p style='font-style:italic;'>Since 1.0.16 (Release 7.1)</p><p>Creates SIP registration of a device/application (WebPhone, Mobile, softphone)</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>VoipCalling</td><td>Registering as VoIP device and making VoIP calls</td></tr></tbody></table><h4>API Group</h4><p>Heavy</p>
        public Task<CreateSipRegistrationResponse> Post()
        {
            return RC.Post<CreateSipRegistrationResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.16 (Release 7.1)</p><p>Creates SIP registration of a device/application (WebPhone, Mobile, softphone)</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>VoipCalling</td><td>Registering as VoIP device and making VoIP calls</td></tr></tbody></table><h4>API Group</h4><p>Heavy</p>
        public Task<CreateSipRegistrationResponse> Post(object parameters)
        {
            return RC.Post<CreateSipRegistrationResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.16 (Release 7.1)</p><p>Creates SIP registration of a device/application (WebPhone, Mobile, softphone)</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>VoipCalling</td><td>Registering as VoIP device and making VoIP calls</td></tr></tbody></table><h4>API Group</h4><p>Heavy</p>
        public Task<CreateSipRegistrationResponse> Post(CreateSipRegistrationRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
