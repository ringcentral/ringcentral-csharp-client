
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Presence : Model
    {
        internal Presence(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "presence";
            }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public class GetResponse
        {
            public string uri { get; set; }
            public bool? allowSeeMyPresence { get; set; }
            public string dndStatus { get; set; }
            public Extension extension { get; set; }
            public string message { get; set; }
            public bool? pickUpCallsOnHold { get; set; }
            public string presenceStatus { get; set; }
            public bool? ringOnMonitoredCall { get; set; }
            public string telephonyStatus { get; set; }
            public string userStatus { get; set; }
            public class Extension
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string extensionNumber { get; set; }
            }
        }
    }
}
