
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
        public partial class MeetingServiceInfo
        {
            // Canonical URI of a meeting service info resource
            public string uri { get; set; }
            // URI to retrieve support information for meetings functionality
            public string supportUri { get; set; }
            // URI to retrieve international dial in numbers
            public string intlDialInNumbersUri { get; set; }
            // External user data
            public ExternalUserInfo externalUserInfo { get; set; }
            // Dial-in numbers data
            public DialInNumbers dialInNumbers { get; set; }
        }
    }
}
