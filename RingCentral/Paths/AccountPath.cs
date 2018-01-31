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
        public CallLogSyncPath CallLogSync()
        {
            return new CallLogSyncPath(this);
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
        public BotPath Bot()
        {
            return new BotPath(this);
        }
        public PresencePath Presence()
        {
            return new PresencePath(this);
        }
        public UserRolePath UserRole(string _id)
        {
            return new UserRolePath(this, _id);
        }
        public UserRolePath UserRole()
        {
            return new UserRolePath(this);
        }
        public BusinessHoursPath BusinessHours()
        {
            return new BusinessHoursPath(this);
        }
        public GreetingPath Greeting(string _id)
        {
            return new GreetingPath(this, _id);
        }
        public GreetingPath Greeting()
        {
            return new GreetingPath(this);
        }
        public AnsweringRulePath AnsweringRule(string _id)
        {
            return new AnsweringRulePath(this, _id);
        }
        public AnsweringRulePath AnsweringRule()
        {
            return new AnsweringRulePath(this);
        }
        public IvrMenusPath IvrMenus(string _id)
        {
            return new IvrMenusPath(this, _id);
        }
        public IvrMenusPath IvrMenus()
        {
            return new IvrMenusPath(this);
        }
        public IvrPromptsPath IvrPrompts(string _id)
        {
            return new IvrPromptsPath(this, _id);
        }
        public IvrPromptsPath IvrPrompts()
        {
            return new IvrPromptsPath(this);
        }
        public BusinessAddressPath BusinessAddress()
        {
            return new BusinessAddressPath(this);
        }
        public ServiceInfoPath ServiceInfo()
        {
            return new ServiceInfoPath(this);
        }
        public DialingPlanPath DialingPlan()
        {
            return new DialingPlanPath(this);
        }
        public PhoneNumberPath PhoneNumber(string _id)
        {
            return new PhoneNumberPath(this, _id);
        }
        public PhoneNumberPath PhoneNumber()
        {
            return new PhoneNumberPath(this);
        }
        public DevicePath Device(string _id)
        {
            return new DevicePath(this, _id);
        }
        public DevicePath Device()
        {
            return new DevicePath(this);
        }
        public OrderPath Order(string _id)
        {
            return new OrderPath(this, _id);
        }
        public OrderPath Order()
        {
            return new OrderPath(this);
        }
        public LicensesPath Licenses(string _id)
        {
            return new LicensesPath(this, _id);
        }
        public LicensesPath Licenses()
        {
            return new LicensesPath(this);
        }
        public DepartmentPath Department(string _id)
        {
            return new DepartmentPath(this, _id);
        }
        public DepartmentPath Department()
        {
            return new DepartmentPath(this);
        }
        public PagingOnlyGroupsPath PagingOnlyGroups(string _id)
        {
            return new PagingOnlyGroupsPath(this, _id);
        }
        public ParkLocationsPath ParkLocations(string _id)
        {
            return new ParkLocationsPath(this, _id);
        }
        // <p style='font-style:italic;'>Since 1.0.0</p><p>Returns basic information about a particular RingCentral customer account.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetAccountInfoResponse> Get()
        {
            return RC.Get<GetAccountInfoResponse>(Endpoint(true), null);
        }
    }
}
