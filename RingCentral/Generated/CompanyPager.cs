
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CompanyPager : Model
    {
        internal CompanyPager(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "company-pager";
            }
        }
        public Task<PostResponse> Post(object requestBody)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PostResponse> Post(PostRequest requestBody)
        {
            return Post(requestBody as object);
        }
        public class PostRequest
        {
            public From from { get; set; }
            public int? replyOn { get; set; }
            public string text { get; set; }
            public To[] to { get; set; }
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
        }
        public class PostResponse
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
    }
}
