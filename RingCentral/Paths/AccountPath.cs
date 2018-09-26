using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AccountPath : PathSegment
    {
        internal AccountPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "account";
            }
        }
        public ExtensionPath Extension(string _id)
        {
            return new ExtensionPath(this, _id);
        }
        public ExtensionPath Extension()
        {
            return new ExtensionPath(this, "~");
        }
        public CallLogPath CallLog(string _id)
        {
            return new CallLogPath(this, _id);
        }
        public CallLogPath CallLog()
        {
            return new CallLogPath(this);
        }
        public ActiveCallsPath ActiveCalls()
        {
            return new ActiveCallsPath(this);
        }
        public RecordingPath Recording(string _id)
        {
            return new RecordingPath(this, _id);
        }
        public DirectoryPath Directory()
        {
            return new DirectoryPath(this);
        }
        public PresencePath Presence()
        {
            return new PresencePath(this);
        }
        public BusinessHoursPath BusinessHours()
        {
            return new BusinessHoursPath(this);
        }
        public AnsweringRulePath AnsweringRule(string _id)
        {
            return new AnsweringRulePath(this, _id);
        }
        public AnsweringRulePath AnsweringRule()
        {
            return new AnsweringRulePath(this);
        }
        public GreetingPath Greeting(string _id)
        {
            return new GreetingPath(this, _id);
        }
        public GreetingPath Greeting()
        {
            return new GreetingPath(this);
        }
        public IvrPromptsPath IvrPrompts(string _id)
        {
            return new IvrPromptsPath(this, _id);
        }
        public IvrPromptsPath IvrPrompts()
        {
            return new IvrPromptsPath(this);
        }
        public IvrMenusPath IvrMenus(string _id)
        {
            return new IvrMenusPath(this, _id);
        }
        public CallRecordingPath CallRecording()
        {
            return new CallRecordingPath(this);
        }
        public BusinessAddressPath BusinessAddress()
        {
            return new BusinessAddressPath(this);
        }
        public ServiceInfoPath ServiceInfo()
        {
            return new ServiceInfoPath(this);
        }
        public PhoneNumberPath PhoneNumber(string _id)
        {
            return new PhoneNumberPath(this, _id);
        }
        public PhoneNumberPath PhoneNumber()
        {
            return new PhoneNumberPath(this);
        }
        public TemplatesPath Templates(string _id)
        {
            return new TemplatesPath(this, _id);
        }
        public TemplatesPath Templates()
        {
            return new TemplatesPath(this);
        }
        public BotsPath Bots()
        {
            return new BotsPath(this);
        }
        public PagingOnlyGroupsPath PagingOnlyGroups(string _id)
        {
            return new PagingOnlyGroupsPath(this, _id);
        }
        public LicensesPath Licenses(string _id)
        {
            return new LicensesPath(this, _id);
        }
        public LicensesPath Licenses()
        {
            return new LicensesPath(this);
        }
        public CallQueuesPath CallQueues(string _id)
        {
            return new CallQueuesPath(this, _id);
        }
        public CallQueuesPath CallQueues()
        {
            return new CallQueuesPath(this);
        }
        public CallMonitoringGroupsPath CallMonitoringGroups(string _id)
        {
            return new CallMonitoringGroupsPath(this, _id);
        }
        public CallMonitoringGroupsPath CallMonitoringGroups()
        {
            return new CallMonitoringGroupsPath(this);
        }
        public DevicePath Device(string _id)
        {
            return new DevicePath(this, _id);
        }
        public DevicePath Device()
        {
            return new DevicePath(this);
        }
        public TelephonyPath Telephony()
        {
            return new TelephonyPath(this);
        }
        // Returns basic information about a particular RingCentral customer account.
        public Task<GetAccountInfoResponse> Get()
        {
            return RC.Get<GetAccountInfoResponse>(Endpoint(true), null);
        }
    }
}
