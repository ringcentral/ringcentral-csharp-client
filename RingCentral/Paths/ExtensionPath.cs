using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ExtensionPath : Model
    {
        internal ExtensionPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "extension";
            }
        }
        public ActiveCallsPath ActiveCalls()
        {
            return new ActiveCallsPath(this);
        }
        public AddressBookSyncPath AddressBookSync()
        {
            return new AddressBookSyncPath(this);
        }
        public AddressBookPath AddressBook()
        {
            return new AddressBookPath(this);
        }
        public AnsweringRulePath AnsweringRule(ID _id)
        {
            return new AnsweringRulePath(this, _id);
        }
        public AnsweringRulePath AnsweringRule()
        {
            return new AnsweringRulePath(this);
        }
        public AuthzProfilePath AuthzProfile()
        {
            return new AuthzProfilePath(this);
        }
        public BlockedNumberPath BlockedNumber(ID _id)
        {
            return new BlockedNumberPath(this, _id);
        }
        public BlockedNumberPath BlockedNumber()
        {
            return new BlockedNumberPath(this);
        }
        public BusinessHoursPath BusinessHours()
        {
            return new BusinessHoursPath(this);
        }
        public CallLogPath CallLog(ID _id)
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
        public CompanyPagerPath CompanyPager()
        {
            return new CompanyPagerPath(this);
        }
        public ConferencingPath Conferencing()
        {
            return new ConferencingPath(this);
        }
        public DevicePath Device(ID _id)
        {
            return new DevicePath(this, _id);
        }
        public DevicePath Device()
        {
            return new DevicePath(this);
        }
        public FaxPath Fax()
        {
            return new FaxPath(this);
        }
        public ForwardingNumberPath ForwardingNumber()
        {
            return new ForwardingNumberPath(this);
        }
        public GrantPath Grant()
        {
            return new GrantPath(this);
        }
        public GreetingPath Greeting(ID _id)
        {
            return new GreetingPath(this, _id);
        }
        public GreetingPath Greeting()
        {
            return new GreetingPath(this);
        }
        public MeetingPath Meeting(ID _id)
        {
            return new MeetingPath(this, _id);
        }
        public MeetingPath Meeting()
        {
            return new MeetingPath(this);
        }
        public MeetingServiceInfoPath MeetingServiceInfo()
        {
            return new MeetingServiceInfoPath(this);
        }
        public MessageStorePath MessageStore(ID _id)
        {
            return new MessageStorePath(this, _id);
        }
        public MessageStorePath MessageStore()
        {
            return new MessageStorePath(this);
        }
        public MessageSyncPath MessageSync()
        {
            return new MessageSyncPath(this);
        }
        public PhoneNumberPath PhoneNumber(ID _id)
        {
            return new PhoneNumberPath(this, _id);
        }
        public PhoneNumberPath PhoneNumber()
        {
            return new PhoneNumberPath(this);
        }
        public PresencePath Presence()
        {
            return new PresencePath(this);
        }
        public ProfileImagePath ProfileImage(ID _id)
        {
            return new ProfileImagePath(this, _id);
        }
        public ProfileImagePath ProfileImage()
        {
            return new ProfileImagePath(this);
        }
        public RingoutPath Ringout(ID _id)
        {
            return new RingoutPath(this, _id);
        }
        public RingoutPath Ringout()
        {
            return new RingoutPath(this);
        }
        public SmsPath Sms()
        {
            return new SmsPath(this);
        }
        // Get Extension List
        public Task<ListResponse> List()
        {
            return RC.Get<ListResponse>(Endpoint(false), null);
        }
        // Get Extension List
        public Task<ListResponse> List(object parameters)
        {
            return RC.Get<ListResponse>(Endpoint(false), parameters);
        }
        // Get Extension List
        public Task<ListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default.
            public long? @perPage { get; set; }
            // Extension current state. Multiple values are supported. If 'Unassigned' is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned
            public string @status { get; set; }
            // Extension type. Multiple values are supported
            public string @type { get; set; }
        }
        public partial class ListResponse
        {
            // List of extensions with extension information
            public ExtensionInfo[] @records { get; set; }
            // Information on navigation
            public NavigationInfo @navigation { get; set; }
            // Information on paging
            public PagingInfo @paging { get; set; }
        }
        // Get Extension Info by ID
        public Task<ExtensionInfo> Get()
        {
            return RC.Get<ExtensionInfo>(Endpoint(true), null);
        }
        // Update Extension by ID
        public Task<ExtensionInfo> Put()
        {
            return RC.Put<ExtensionInfo>(Endpoint(true), null);
        }
        // Update Extension by ID
        public Task<ExtensionInfo> Put(object parameters)
        {
            return RC.Put<ExtensionInfo>(Endpoint(true), parameters);
        }
        // Update Extension by ID
        public Task<ExtensionInfo> Put(ExtensionParameters parameters)
        {
            return Put(parameters as object);
        }
    }
}
