
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
        public CallLog CallLog(string _id = null)
        {
            return new CallLog(this, _id);
        }
        public Department Department(string _id = null)
        {
            return new Department(this, _id);
        }
        public Device Device(string _id = null)
        {
            return new Device(this, _id);
        }
        public Extension Extension(string _id = "~")
        {
            return new Extension(this, _id);
        }
        public Order Order(string _id = null)
        {
            return new Order(this, _id);
        }
        public PhoneNumber PhoneNumber(string _id = null)
        {
            return new PhoneNumber(this, _id);
        }
        public Recording Recording(string _id = null)
        {
            return new Recording(this, _id);
        }
        public ServiceInfo ServiceInfo()
        {
            return new ServiceInfo(this);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string mainNumber { get; set; }
            public Operator @operator { get; set; }
            public string partnerId { get; set; }
            public ServiceInfo serviceInfo { get; set; }
            public string setupWizardState { get; set; }
            public string status { get; set; }
            public StatusInfo statusInfo { get; set; }
            public class Operator
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
            public class ServiceInfo
            {
                public string uri { get; set; }
                public BillingPlan billingPlan { get; set; }
                public Brand brand { get; set; }
                public ServicePlan servicePlan { get; set; }
                public TargetServicePlan targetServicePlan { get; set; }
                public class BillingPlan
                {
                    public string id { get; set; }
                    public string name { get; set; }
                    public string durationUnit { get; set; }
                    public string duration { get; set; }
                    public string type { get; set; }
                }
                public class Brand
                {
                    public string id { get; set; }
                    public string name { get; set; }
                    public HomeCountry homeCountry { get; set; }
                    public class HomeCountry
                    {
                        public string id { get; set; }
                        public string uri { get; set; }
                        public string name { get; set; }
                    }
                }
                public class ServicePlan
                {
                    public string id { get; set; }
                    public string name { get; set; }
                    public string edition { get; set; }
                }
                public class TargetServicePlan
                {
                    public string id { get; set; }
                    public string name { get; set; }
                }
            }
            public class StatusInfo
            {
                public string comment { get; set; }
                public string reason { get; set; }
            }
        }
    }
}
