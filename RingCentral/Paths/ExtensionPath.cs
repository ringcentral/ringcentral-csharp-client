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
        public PhoneNumberPath PhoneNumber(string _id)
        {
            return new PhoneNumberPath(this, _id);
        }
        public PhoneNumberPath PhoneNumber()
        {
            return new PhoneNumberPath(this);
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
        public RingOutPath RingOut(string _id)
        {
            return new RingOutPath(this, _id);
        }
        public RingOutPath RingOut()
        {
            return new RingOutPath(this);
        }
        public DirectRingOutPath DirectRingOut()
        {
            return new DirectRingOutPath(this);
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
        public ForwardingNumberPath ForwardingNumber(string _id)
        {
            return new ForwardingNumberPath(this, _id);
        }
        public ForwardingNumberPath ForwardingNumber()
        {
            return new ForwardingNumberPath(this);
        }
        public BlockedNumberPath BlockedNumber(string _id)
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
        public CallerIdPath CallerId()
        {
            return new CallerIdPath(this);
        }
        public CredentialsPath Credentials()
        {
            return new CredentialsPath(this);
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
        public FreeNumbersPath FreeNumbers()
        {
            return new FreeNumbersPath(this);
        }
        public DevicePath Device(string _id)
        {
            return new DevicePath(this, _id);
        }
        public DevicePath Device()
        {
            return new DevicePath(this);
        }
        public ReportingPath Reporting()
        {
            return new ReportingPath(this);
        }
        // <p style='font-style:italic;'>Since 1.0.0</p><p>Returns the list of extensions created for a particular account. All types of extensions are included in this list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GetExtensionListResponse> List()
        {
            return RC.Get<GetExtensionListResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.0</p><p>Returns the list of extensions created for a particular account. All types of extensions are included in this list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GetExtensionListResponse> List(object parameters)
        {
            return RC.Get<GetExtensionListResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.0</p><p>Returns the list of extensions created for a particular account. All types of extensions are included in this list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GetExtensionListResponse> List(ListParameters parameters)
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
            public string[] @status { get; set; }
            // Extension type. Multiple values are supported
            public string[] @type { get; set; }
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Creates an extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ExtensionInfo> Post()
        {
            return RC.Post<ExtensionInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Creates an extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ExtensionInfo> Post(object parameters)
        {
            return RC.Post<ExtensionInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Creates an extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ExtensionInfo> Post(ExtensionCreationRequest parameters)
        {
            return Post(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.0</p><p>Returns basic information about a particular extension of an account.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetExtensionInfoResponse> Get()
        {
            return RC.Get<GetExtensionInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetExtensionInfoResponse> Put()
        {
            return RC.Put<GetExtensionInfoResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetExtensionInfoResponse> Put(object parameters)
        {
            return RC.Put<GetExtensionInfoResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<GetExtensionInfoResponse> Put(ExtensionUpdateRequest parameters)
        {
            return Put(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.10 (Release 6.2)</p><p>Deletes extension(s) by ID(s).</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
