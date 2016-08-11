
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Account : Model
    {
        internal Account(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "account";
            }
        }
        public ActiveCalls ActiveCalls()
        {
            return new ActiveCalls(this);
        }
        public BusinessAddress BusinessAddress()
        {
            return new BusinessAddress(this);
        }
        public CallLog CallLog(ID _id)
        {
            return new CallLog(this, _id);
        }
        public CallLog CallLog()
        {
            return new CallLog(this, null);
        }
        public Department Department(ID _id)
        {
            return new Department(this, _id);
        }
        public Department Department()
        {
            return new Department(this, null);
        }
        public Device Device(ID _id)
        {
            return new Device(this, _id);
        }
        public Device Device()
        {
            return new Device(this, null);
        }
        public DialingPlan DialingPlan()
        {
            return new DialingPlan(this);
        }
        public Extension Extension(ID _id)
        {
            return new Extension(this, _id);
        }
        public Extension Extension()
        {
            return new Extension(this, "~");
        }
        public Order Order(ID _id)
        {
            return new Order(this, _id);
        }
        public Order Order()
        {
            return new Order(this, null);
        }
        public PhoneNumber PhoneNumber(ID _id)
        {
            return new PhoneNumber(this, _id);
        }
        public PhoneNumber PhoneNumber()
        {
            return new PhoneNumber(this, null);
        }
        public Recording Recording(ID _id)
        {
            return new Recording(this, _id);
        }
        public Recording Recording()
        {
            return new Recording(this, null);
        }
        public ServiceInfo ServiceInfo()
        {
            return new ServiceInfo(this);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of an account
            public string id { get; set; }
            // Canonical URI of an account
            public string uri { get; set; }
            // Main phone number of the current account
            public string mainNumber { get; set; }
            // Operator's extension information. This extension will receive all calls and messages intended for the operator
            public ExtensionInfo @operator { get; set; }
            // Additional account identifier, developed and applied by the client
            public string partnerId { get; set; }
            // Account service information, including brand, service plan and billing plan
            public ServiceInfo serviceInfo { get; set; }
            // Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'
            public string setupWizardState { get; set; }
            // Status of the current account
            public string status { get; set; }
            // Status information (reason, comment, lifetime). Returned for 'Disabled' status only
            public StatusInfo statusInfo { get; set; }
        }
    }
}
