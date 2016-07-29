
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
        public class ListQueryParams
        {
            public int? page { get; set; }
            public int? perPage { get; set; }
            public string status { get; set; }
            public string type { get; set; }
        }
        public class ListResponse
        {
            public Record[] records { get; set; }
            public Navigation navigation { get; set; }
            public Paging paging { get; set; }
            public class Record
            {
                public string id { get; set; }
                public string uri { get; set; }
                public Contact contact { get; set; }
                public Departments departments { get; set; }
                public string extensionNumber { get; set; }
                public string name { get; set; }
                public string partnerId { get; set; }
                public Permissions permissions { get; set; }
                public ProfileImage profileImage { get; set; }
                public Reference[] references { get; set; }
                public RegionalSettings regionalSettings { get; set; }
                public ServiceFeature[] serviceFeatures { get; set; }
                public string setupWizardState { get; set; }
                public string status { get; set; }
                public StatusInfo statusInfo { get; set; }
                public string type { get; set; }
                public class Contact
                {
                    public string firstName { get; set; }
                    public string lastName { get; set; }
                    public string company { get; set; }
                    public string email { get; set; }
                    public string businessPhone { get; set; }
                    public BusinessAddress businessAddress { get; set; }
                    public class BusinessAddress
                    {
                        public string country { get; set; }
                        public string state { get; set; }
                        public string city { get; set; }
                        public string street { get; set; }
                        public string zip { get; set; }
                    }
                }
                public class Departments
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string extensionNumber { get; set; }
                }
                public class Permissions
                {
                    public Admin admin { get; set; }
                    public InternationalCalling internationalCalling { get; set; }
                    public class Admin
                    {
                        public bool? enabled { get; set; }
                    }
                    public class InternationalCalling
                    {
                        public bool? enabled { get; set; }
                    }
                }
                public class ProfileImage
                {
                    public string uri { get; set; }
                    public string etag { get; set; }
                    public string lastModified { get; set; }
                    public string contentType { get; set; }
                    public string[] scales { get; set; }
                }
                public class Reference
                {
                    public string @ref { get; set; }
                    public string type { get; set; }
                }
                public class RegionalSettings
                {
                    public HomeCountry homeCountry { get; set; }
                    public Timezone timezone { get; set; }
                    public Language language { get; set; }
                    public GreetingLanguage greetingLanguage { get; set; }
                    public FormattingLocale formattingLocale { get; set; }
                    public class HomeCountry
                    {
                        public string id { get; set; }
                        public string uri { get; set; }
                        public string name { get; set; }
                    }
                    public class Timezone
                    {
                        public string id { get; set; }
                        public string uri { get; set; }
                        public string name { get; set; }
                        public string description { get; set; }
                    }
                    public class Language
                    {
                        public string id { get; set; }
                        public string uri { get; set; }
                        public bool? greeting { get; set; }
                        public bool? formattingLocale { get; set; }
                        public string localeCode { get; set; }
                        public string name { get; set; }
                        public bool? ui { get; set; }
                    }
                    public class GreetingLanguage
                    {
                        public string id { get; set; }
                        public string localeCode { get; set; }
                        public string name { get; set; }
                    }
                    public class FormattingLocale
                    {
                        public string id { get; set; }
                        public string localeCode { get; set; }
                        public string name { get; set; }
                    }
                }
                public class ServiceFeature
                {
                    public bool? enabled { get; set; }
                    public string featureName { get; set; }
                    public string reason { get; set; }
                }
                public class StatusInfo
                {
                    public string comment { get; set; }
                    public string reason { get; set; }
                }
            }
            public class Navigation
            {
                public FirstPage firstPage { get; set; }
                public NextPage nextPage { get; set; }
                public PreviousPage previousPage { get; set; }
                public LastPage lastPage { get; set; }
                public class FirstPage
                {
                    public string uri { get; set; }
                }
                public class NextPage
                {
                    public string uri { get; set; }
                }
                public class PreviousPage
                {
                    public string uri { get; set; }
                }
                public class LastPage
                {
                    public string uri { get; set; }
                }
            }
            public class Paging
            {
                public int? page { get; set; }
                public int? perPage { get; set; }
                public int? pageStart { get; set; }
                public int? pageEnd { get; set; }
                public int? totalPages { get; set; }
                public int? totalElements { get; set; }
            }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public Contact contact { get; set; }
            public Departments departments { get; set; }
            public string extensionNumber { get; set; }
            public string name { get; set; }
            public string partnerId { get; set; }
            public Permissions permissions { get; set; }
            public ProfileImage profileImage { get; set; }
            public Reference[] references { get; set; }
            public RegionalSettings regionalSettings { get; set; }
            public ServiceFeature[] serviceFeatures { get; set; }
            public string setupWizardState { get; set; }
            public string status { get; set; }
            public StatusInfo statusInfo { get; set; }
            public string type { get; set; }
            public class Contact
            {
                public string firstName { get; set; }
                public string lastName { get; set; }
                public string company { get; set; }
                public string email { get; set; }
                public string businessPhone { get; set; }
                public BusinessAddress businessAddress { get; set; }
                public class BusinessAddress
                {
                    public string country { get; set; }
                    public string state { get; set; }
                    public string city { get; set; }
                    public string street { get; set; }
                    public string zip { get; set; }
                }
            }
            public class Departments
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string extensionNumber { get; set; }
            }
            public class Permissions
            {
                public Admin admin { get; set; }
                public InternationalCalling internationalCalling { get; set; }
                public class Admin
                {
                    public bool? enabled { get; set; }
                }
                public class InternationalCalling
                {
                    public bool? enabled { get; set; }
                }
            }
            public class ProfileImage
            {
                public string uri { get; set; }
                public string etag { get; set; }
                public string lastModified { get; set; }
                public string contentType { get; set; }
                public string[] scales { get; set; }
            }
            public class Reference
            {
                public string @ref { get; set; }
                public string type { get; set; }
            }
            public class RegionalSettings
            {
                public HomeCountry homeCountry { get; set; }
                public Timezone timezone { get; set; }
                public Language language { get; set; }
                public GreetingLanguage greetingLanguage { get; set; }
                public FormattingLocale formattingLocale { get; set; }
                public class HomeCountry
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string name { get; set; }
                }
                public class Timezone
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string name { get; set; }
                    public string description { get; set; }
                }
                public class Language
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public bool? greeting { get; set; }
                    public bool? formattingLocale { get; set; }
                    public string localeCode { get; set; }
                    public string name { get; set; }
                    public bool? ui { get; set; }
                }
                public class GreetingLanguage
                {
                    public string id { get; set; }
                    public string localeCode { get; set; }
                    public string name { get; set; }
                }
                public class FormattingLocale
                {
                    public string id { get; set; }
                    public string localeCode { get; set; }
                    public string name { get; set; }
                }
            }
            public class ServiceFeature
            {
                public bool? enabled { get; set; }
                public string featureName { get; set; }
                public string reason { get; set; }
            }
            public class StatusInfo
            {
                public string comment { get; set; }
                public string reason { get; set; }
            }
        }
    }
}
