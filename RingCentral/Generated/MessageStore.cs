
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class MessageStore : Model
    {
        internal MessageStore(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "message-store";
            }
        }
        public Content Content(string _id = null)
        {
            return new Content(this, _id);
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
            public string availability { get; set; }
            public int? conversationId { get; set; }
            public string dateFrom { get; set; }
            public string dateTo { get; set; }
            public string direction { get; set; }
            public bool? distinctConversations { get; set; }
            public string messageType { get; set; }
            public string readStatus { get; set; }
            public int? page { get; set; }
            public int? perPage { get; set; }
            public string phoneNumber { get; set; }
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
                public Attachment[] attachments { get; set; }
                public string availability { get; set; }
                public int? conversationId { get; set; }
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
        public Task<System.Net.Http.HttpResponseMessage> Delete(object queryParams)
        {
            return RC.Delete(Endpoint(true), queryParams);
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete(DeleteQueryParams queryParams = null)
        {
            return Delete(queryParams as object);
        }
        public class DeleteQueryParams
        {
            public bool? purge { get; set; }
            public int? conversationId { get; set; }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public Attachment[] attachments { get; set; }
            public string availability { get; set; }
            public int? conversationId { get; set; }
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
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public class PutRequest
        {
            public string readStatus { get; set; }
        }
        public class PutResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public Attachment[] attachments { get; set; }
            public string availability { get; set; }
            public int? conversationId { get; set; }
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
