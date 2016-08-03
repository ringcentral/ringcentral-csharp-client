
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServiceInfo : Model
    {
        internal ServiceInfo(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "service-info";
            }
        }
        public class MeetingServiceInfo
        {
            public string uri { get; set; }
            public string supportUri { get; set; }
            public string intlDialInNumbersUri { get; set; }
            public ExternalUserInfo externalUserInfo { get; set; }
            public DialInNumbers dialInNumbers { get; set; }
            public class ExternalUserInfo
            {
                public string accountId { get; set; }
                public string userId { get; set; }
                public string userToken { get; set; }
                public int? userType { get; set; }
            }
            public class DialInNumbers
            {
                public string phoneNumber { get; set; }
                public string formattedNumber { get; set; }
                public string location { get; set; }
                public Country country { get; set; }
                public class Country
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string callingCode { get; set; }
                    public string isoCode { get; set; }
                    public string name { get; set; }
                }
            }
        }
        public class AccountServiceInfo
        {
            public string uri { get; set; }
            public string servicePlanName { get; set; }
            public ServiceFeature[] serviceFeatures { get; set; }
            public Limit[] limits { get; set; }
            public class ServiceFeature
            {
                public string featureName { get; set; }
                public bool? enabled { get; set; }
            }
            public class Limit
            {
                public int? freeSoftPhoneLinesPerExtension { get; set; }
                public int? meetingSize { get; set; }
                public int? maxMonitoredExtensionsPerUser { get; set; }
            }
        }
    }
}
