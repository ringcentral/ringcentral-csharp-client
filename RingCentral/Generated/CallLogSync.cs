
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallLogSync : Model
    {
        internal CallLogSync(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "call-log-sync";
            }
        }
        public Task<GetResponse> Get(object queryParams)
        {
            return RC.Get<GetResponse>(Endpoint(false), queryParams);
        }
        public Task<GetResponse> Get(GetQueryParams queryParams = null)
        {
            return Get(queryParams as object);
        }
        public class GetQueryParams
        {
            public string syncType { get; set; }
            public string syncToken { get; set; }
            public string dateFrom { get; set; }
            public int? recordCount { get; set; }
            public string statusGroup { get; set; }
        }
        public class GetResponse
        {
            public Record[] records { get; set; }
            public SyncInfo syncInfo { get; set; }
            public class Record
            {
                public string id { get; set; }
                public string uri { get; set; }
                public string sessionId { get; set; }
                public From from { get; set; }
                public To to { get; set; }
                public string type { get; set; }
                public string direction { get; set; }
                public string action { get; set; }
                public string result { get; set; }
                public string startTime { get; set; }
                public int? duration { get; set; }
                public Recording recording { get; set; }
                public string lastModifiedTime { get; set; }
                public string transport { get; set; }
                public Leg[] legs { get; set; }
                public class From
                {
                    public string phoneNumber { get; set; }
                    public string extensionNumber { get; set; }
                    public string location { get; set; }
                    public string name { get; set; }
                }
                public class To
                {
                    public string phoneNumber { get; set; }
                    public string extensionNumber { get; set; }
                    public string location { get; set; }
                    public string name { get; set; }
                }
                public class Recording
                {
                    public int? id { get; set; }
                    public string uri { get; set; }
                    public string type { get; set; }
                    public string contentUri { get; set; }
                }
                public class Leg
                {
                    public string action { get; set; }
                    public string direction { get; set; }
                    public int? duration { get; set; }
                    public Extension extension { get; set; }
                    public string legType { get; set; }
                    public string startTime { get; set; }
                    public string type { get; set; }
                    public string result { get; set; }
                    public From from { get; set; }
                    public To to { get; set; }
                    public string transport { get; set; }
                    public Recording recording { get; set; }
                    public class Extension
                    {
                        public int? id { get; set; }
                        public string uri { get; set; }
                    }
                    public class From
                    {
                        public string phoneNumber { get; set; }
                        public string extensionNumber { get; set; }
                        public string location { get; set; }
                        public string name { get; set; }
                    }
                    public class To
                    {
                        public string phoneNumber { get; set; }
                        public string extensionNumber { get; set; }
                        public string location { get; set; }
                        public string name { get; set; }
                    }
                    public class Recording
                    {
                        public int? id { get; set; }
                        public string uri { get; set; }
                        public string type { get; set; }
                        public string contentUri { get; set; }
                    }
                }
            }
            public class SyncInfo
            {
                public string syncType { get; set; }
                public string syncToken { get; set; }
                public string syncTime { get; set; }
            }
        }
    }
}
