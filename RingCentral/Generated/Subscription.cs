
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Subscription : Model
    {
        internal Subscription(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "subscription";
            }
        }
        public Task<PostResponse> Post(object requestBody, object queryParams)
        {
            return RC.Post<PostResponse>(Endpoint(false), requestBody, queryParams);
        }
        public Task<PostResponse> Post(PostRequest requestBody, object queryParams)
        {
            return Post(requestBody as object, queryParams);
        }
        public Task<PostResponse> Post(object requestBody, PostQueryParams queryParams = null)
        {
            return Post(requestBody, queryParams as object);
        }
        public Task<PostResponse> Post(PostRequest requestBody, PostQueryParams queryParams = null)
        {
            return Post(requestBody as object, queryParams as object);
        }
        public class PostQueryParams
        {
            public bool? aggregated { get; set; }
        }
        public class PostRequest
        {
            public string[] eventFilters { get; set; }
            public DeliveryMode deliveryMode { get; set; }
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
            }
        }
        public class PostResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string[] eventFilters { get; set; }
            public string expirationTime { get; set; }
            public int? expiresIn { get; set; }
            public string status { get; set; }
            public string creationTime { get; set; }
            public DeliveryMode deliveryMode { get; set; }
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
                public string address { get; set; }
                public string subscriberKey { get; set; }
                public string secretKey { get; set; }
                public string encryptionAlgorithm { get; set; }
                public string encryptionKey { get; set; }
            }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public class GetResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string[] eventFilters { get; set; }
            public string expirationTime { get; set; }
            public int? expiresIn { get; set; }
            public string status { get; set; }
            public string creationTime { get; set; }
            public DeliveryMode deliveryMode { get; set; }
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
                public string address { get; set; }
                public string subscriberKey { get; set; }
                public string secretKey { get; set; }
                public string encryptionAlgorithm { get; set; }
                public string encryptionKey { get; set; }
            }
        }
        public Task<PutResponse> Put(object requestBody, object queryParams)
        {
            return RC.Put<PutResponse>(Endpoint(true), requestBody, queryParams);
        }
        public Task<PutResponse> Put(PutRequest requestBody, object queryParams)
        {
            return Put(requestBody as object, queryParams);
        }
        public Task<PutResponse> Put(object requestBody, PutQueryParams queryParams = null)
        {
            return Put(requestBody, queryParams as object);
        }
        public Task<PutResponse> Put(PutRequest requestBody, PutQueryParams queryParams = null)
        {
            return Put(requestBody as object, queryParams as object);
        }
        public class PutQueryParams
        {
            public bool? aggregated { get; set; }
        }
        public class PutRequest
        {
            public string[] eventFilters { get; set; }
        }
        public class PutResponse
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string[] eventFilters { get; set; }
            public string expirationTime { get; set; }
            public int? expiresIn { get; set; }
            public string status { get; set; }
            public string creationTime { get; set; }
            public DeliveryMode deliveryMode { get; set; }
            public class DeliveryMode
            {
                public string transportType { get; set; }
                public bool? encryption { get; set; }
                public string address { get; set; }
                public string subscriberKey { get; set; }
                public string secretKey { get; set; }
                public string encryptionAlgorithm { get; set; }
                public string encryptionKey { get; set; }
            }
        }
    }
}
