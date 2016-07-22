
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MessageSync : Model
    {
        internal MessageSync(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "message-sync";
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
            public long? conversationId { get; set; }
            public string dateFrom { get; set; }
            public string dateTo { get; set; }
            public string direction { get; set; }
            public bool? distinctConversations { get; set; }
            public string messageType { get; set; }
            public int? recordCount { get; set; }
            public string syncToken { get; set; }
            public string syncType { get; set; }
        }
        public class GetResponse
        {
            public Record[] records { get; set; }
            public SyncInfo syncInfo { get; set; }
            public class Record
            {
                public string id { get; set; }
                public string uri { get; set; }
                public Attachment[] attachments { get; set; }
                public string availability { get; set; }
                public long? conversationId { get; set; }
                public string creationTime { get; set; }
                public string deliveryErrorCode { get; set; }
                public string direction { get; set; }
                public int? faxPageCount { get; set; }
                public string faxResolution { get; set; }
                public From from { get; set; }
                public string lastModifiedTime { get; set; }
                public string messageStatus { get; set; }
                public bool? pgToDepartment { get; set; }
                public string priority { get; set; }
                public string readStatus { get; set; }
                public string smsDeliveryTime { get; set; }
                public int? smsSendingAttemptsCount { get; set; }
                public string subject { get; set; }
                public To[] to { get; set; }
                public string type { get; set; }
                public string vmTranscriptionStatus { get; set; }
                public class Attachment
                {
                    public string id { get; set; }
                    public string uri { get; set; }
                    public string type { get; set; }
                    public string contentType { get; set; }
                    public int? vmDuration { get; set; }
                }
                public class From
                {
                    public string extensionNumber { get; set; }
                    public string location { get; set; }
                    public string messageStatus { get; set; }
                    public string faxErrorCode { get; set; }
                    public string name { get; set; }
                    public string phoneNumber { get; set; }
                }
                public class To
                {
                    public string extensionNumber { get; set; }
                    public string location { get; set; }
                    public string messageStatus { get; set; }
                    public string faxErrorCode { get; set; }
                    public string name { get; set; }
                    public string phoneNumber { get; set; }
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
