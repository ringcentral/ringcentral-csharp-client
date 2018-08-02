using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ExtensionPath : PathSegment
    {
        internal ExtensionPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "extension";
            }
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
        public SmsPath Sms()
        {
            return new SmsPath(this);
        }
        public CompanyPagerPath CompanyPager()
        {
            return new CompanyPagerPath(this);
        }
        public FaxPath Fax()
        {
            return new FaxPath(this);
        }
        public MessageStorePath MessageStore(string _id)
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
        public VoicemailPath Voicemail()
        {
            return new VoicemailPath(this);
        }
        public RingOutPath RingOut(string _id)
        {
            return new RingOutPath(this, _id);
        }
        public RingOutPath RingOut()
        {
            return new RingOutPath(this);
        }
        public AddressBookPath AddressBook()
        {
            return new AddressBookPath(this);
        }
        public AddressBookSyncPath AddressBookSync()
        {
            return new AddressBookSyncPath(this);
        }
        public FavoritePath Favorite()
        {
            return new FavoritePath(this);
        }
        public PresencePath Presence()
        {
            return new PresencePath(this);
        }
        public MeetingPath Meeting(string _id)
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
        public AuthzProfilePath AuthzProfile()
        {
            return new AuthzProfilePath(this);
        }
        public BusinessHoursPath BusinessHours()
        {
            return new BusinessHoursPath(this);
        }
        public CallerBlockingPath CallerBlocking()
        {
            return new CallerBlockingPath(this);
        }
        public ForwardingNumberPath ForwardingNumber(string _id)
        {
            return new ForwardingNumberPath(this, _id);
        }
        public ForwardingNumberPath ForwardingNumber()
        {
            return new ForwardingNumberPath(this);
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
        public PhoneNumberPath PhoneNumber(string _id)
        {
            return new PhoneNumberPath(this, _id);
        }
        public PhoneNumberPath PhoneNumber()
        {
            return new PhoneNumberPath(this);
        }
        public CallerIdPath CallerId()
        {
            return new CallerIdPath(this);
        }
        public GrantPath Grant()
        {
            return new GrantPath(this);
        }
        public NotificationSettingsPath NotificationSettings()
        {
            return new NotificationSettingsPath(this);
        }
        public ProfileImagePath ProfileImage(string _id)
        {
            return new ProfileImagePath(this, _id);
        }
        public ProfileImagePath ProfileImage()
        {
            return new ProfileImagePath(this);
        }
        public ConferencingPath Conferencing()
        {
            return new ConferencingPath(this);
        }
        public DevicePath Device(string _id)
        {
            return new DevicePath(this, _id);
        }
        public DevicePath Device()
        {
            return new DevicePath(this);
        }
        // Returns basic information about a particular extension of an account.
        public Task<GetExtensionInfoResponse> Get()
        {
            return RC.Get<GetExtensionInfoResponse>(Endpoint(true), null);
        }
        // Updates user settings.
        public Task<GetExtensionInfoResponse> Put()
        {
            return RC.Put<GetExtensionInfoResponse>(Endpoint(true), null);
        }
        // Updates user settings.
        public Task<GetExtensionInfoResponse> Put(object parameters)
        {
            return RC.Put<GetExtensionInfoResponse>(Endpoint(true), parameters);
        }
        // Updates user settings.
        public Task<GetExtensionInfoResponse> Put(ExtensionUpdateRequest parameters)
        {
            return Put(parameters as object);
        }
        // Deletes extension(s) by ID(s).
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
        // Returns the list of extensions created for a particular account. All types of extensions are included in this list.
        public Task<GetExtensionListResponse> List()
        {
            return RC.Get<GetExtensionListResponse>(Endpoint(false), null);
        }
        // Returns the list of extensions created for a particular account. All types of extensions are included in this list.
        public Task<GetExtensionListResponse> List(object parameters)
        {
            return RC.Get<GetExtensionListResponse>(Endpoint(false), parameters);
        }
        // Returns the list of extensions created for a particular account. All types of extensions are included in this list.
        public Task<GetExtensionListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed
            public long? @page { get; set; }
            // Indicates the page size (number of items)
            public long? @perPage { get; set; }
            // Extension current state. Multiple values are supported. If 'Unassigned' is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned.
            public string[] @status { get; set; }
            // Extension type. Multiple values are supported
            public string[] @type { get; set; }
        }
        // Creates an extension.
        public Task<ExtensionCreationResponse> Post()
        {
            return RC.Post<ExtensionCreationResponse>(Endpoint(true), null);
        }
        // Creates an extension.
        public Task<ExtensionCreationResponse> Post(object parameters)
        {
            return RC.Post<ExtensionCreationResponse>(Endpoint(true), parameters);
        }
        // Creates an extension.
        public Task<ExtensionCreationResponse> Post(ExtensionCreationRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
