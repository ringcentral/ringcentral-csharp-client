
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Extension : Model
    {
        internal Extension(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "extension";
            }
        }
        public ActiveCalls ActiveCalls()
        {
            return new ActiveCalls(this);
        }
        public AddressBookSync AddressBookSync()
        {
            return new AddressBookSync(this);
        }
        public AddressBook AddressBook()
        {
            return new AddressBook(this);
        }
        public AnsweringRule AnsweringRule(ID _id)
        {
            return new AnsweringRule(this, _id);
        }
        public AnsweringRule AnsweringRule()
        {
            return new AnsweringRule(this, null);
        }
        public BlockedNumber BlockedNumber(ID _id)
        {
            return new BlockedNumber(this, _id);
        }
        public BlockedNumber BlockedNumber()
        {
            return new BlockedNumber(this, null);
        }
        public BusinessHours BusinessHours()
        {
            return new BusinessHours(this);
        }
        public CallLog CallLog(ID _id)
        {
            return new CallLog(this, _id);
        }
        public CallLog CallLog()
        {
            return new CallLog(this, null);
        }
        public CallLogSync CallLogSync()
        {
            return new CallLogSync(this);
        }
        public CompanyPager CompanyPager()
        {
            return new CompanyPager(this);
        }
        public Conferencing Conferencing()
        {
            return new Conferencing(this);
        }
        public Device Device(ID _id)
        {
            return new Device(this, _id);
        }
        public Device Device()
        {
            return new Device(this, null);
        }
        public Fax Fax()
        {
            return new Fax(this);
        }
        public ForwardingNumber ForwardingNumber()
        {
            return new ForwardingNumber(this);
        }
        public Grant Grant()
        {
            return new Grant(this);
        }
        public Meeting Meeting(ID _id)
        {
            return new Meeting(this, _id);
        }
        public Meeting Meeting()
        {
            return new Meeting(this, null);
        }
        public MessageStore MessageStore(ID _id)
        {
            return new MessageStore(this, _id);
        }
        public MessageStore MessageStore()
        {
            return new MessageStore(this, null);
        }
        public MessageSync MessageSync()
        {
            return new MessageSync(this);
        }
        public PhoneNumber PhoneNumber(ID _id)
        {
            return new PhoneNumber(this, _id);
        }
        public PhoneNumber PhoneNumber()
        {
            return new PhoneNumber(this, null);
        }
        public Presence Presence()
        {
            return new Presence(this);
        }
        public ProfileImage ProfileImage(ID _id)
        {
            return new ProfileImage(this, _id);
        }
        public ProfileImage ProfileImage()
        {
            return new ProfileImage(this, null);
        }
        public Ringout Ringout(ID _id)
        {
            return new Ringout(this, _id);
        }
        public Ringout Ringout()
        {
            return new Ringout(this, null);
        }
        public Sms Sms()
        {
            return new Sms(this);
        }
        public Task<ListResponse> List(object queryParams)
        {
            return RC.Get<ListResponse>(Endpoint(false), queryParams);
        }
        public Task<ListResponse> List(ListQueryParams queryParams = null)
        {
            return List(queryParams as object);
        }
        public partial class ListQueryParams
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default.
            public long? perPage { get; set; }
            // Extension current state. Multiple values are supported. If 'Unassigned' is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned
            public string status { get; set; }
            // Extension type. Multiple values are supported
            public string type { get; set; }
        }
        public partial class ListResponse
        {
            // List of extensions with extension information
            public ExtensionInfo[] records { get; set; }
            // Information on navigation
            public NavigationInfo navigation { get; set; }
            // Information on paging
            public PagingInfo paging { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of an extension
            public string id { get; set; }
            // Canonical URI of an extension
            public string uri { get; set; }
            // Contact detailed information
            public ContactInfo contact { get; set; }
            // Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId
            public DepartmentInfo departments { get; set; }
            // Number of department extension
            public string extensionNumber { get; set; }
            // Extension user name
            public string name { get; set; }
            // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
            public string partnerId { get; set; }
            // Extension permissions, corresponding to the Service Web permissions 'Admin' and 'InternationalCalling'
            public ExtensionPermissions permissions { get; set; }
            // Information on profile image
            public ProfileImageInfo profileImage { get; set; }
            // List of non-RC internal identifiers assigned to an extension
            public ReferenceInfo[] references { get; set; }
            // Extension region data (timezone, home country, language)
            public RegionalSettings regionalSettings { get; set; }
            // Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features
            public ExtensionServiceFeatureInfo[] serviceFeatures { get; set; }
            // Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
            public string setupWizardState { get; set; }
            // Extension current state. If the status is 'Unassigned'. Returned for all extensions
            public string status { get; set; }
            // Status information (reason, comment). Returned for 'Disabled' status only
            public StatusInfo statusInfo { get; set; }
            // Extension type
            public string type { get; set; }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public partial class PutResponse
        {
            // Internal identifier of an extension
            public string id { get; set; }
            // Canonical URI of an extension
            public string uri { get; set; }
            // Contact detailed information
            public ContactInfo contact { get; set; }
            // Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId
            public DepartmentInfo departments { get; set; }
            // Number of department extension
            public string extensionNumber { get; set; }
            // Extension user name
            public string name { get; set; }
            // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
            public string partnerId { get; set; }
            // Extension permissions, corresponding to the Service Web permissions 'Admin' and 'InternationalCalling'
            public ExtensionPermissions permissions { get; set; }
            // Information on profile image
            public ProfileImageInfo profileImage { get; set; }
            // List of non-RC internal identifiers assigned to an extension
            public ReferenceInfo[] references { get; set; }
            // Extension region data (timezone, home country, language)
            public RegionalSettings regionalSettings { get; set; }
            // Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features
            public ExtensionServiceFeatureInfo[] serviceFeatures { get; set; }
            // Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
            public string setupWizardState { get; set; }
            // Extension current state. If the status is 'Unassigned'. Returned for all extensions
            public string status { get; set; }
            // Status information (reason, comment). Returned for 'Disabled' status only
            public StatusInfo statusInfo { get; set; }
            // Extension type
            public string type { get; set; }
        }
    }
}
