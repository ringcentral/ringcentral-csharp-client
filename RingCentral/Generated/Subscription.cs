
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
        public partial class PostQueryParams
        {
            // If 'True' then aggregated presence status is returned in a notification payload in the 'presenceStatus' field
            public bool? aggregated { get; set; }
        }
        public partial class PostRequest
        {
            // Mandatory. Collection of URIs to API resources (see Event Types for details). For APNS transport type only message event filter is available
            public string[] eventFilters { get; set; }
            // Notification delivery settings
            public Subscription_Request_DeliveryMode deliveryMode { get; set; }
        }
        public partial class PostResponse
        {
            // Internal identifier of a subscription
            public string id { get; set; }
            // Canonical URI of a subscription
            public string uri { get; set; }
            // Collection of URIs to API resources (message-store/presence/detailed presence)
            public string[] eventFilters { get; set; }
            // Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string expirationTime { get; set; }
            // Subscription lifetime in seconds. The default value is 900
            public long? expiresIn { get; set; }
            // Subscription status
            public string status { get; set; }
            // Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string creationTime { get; set; }
            // Delivery mode data
            public DeliveryMode deliveryMode { get; set; }
        }
        public Task<System.Net.Http.HttpResponseMessage> Delete()
        {
            return RC.Delete(Endpoint(true), null);
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Internal identifier of a subscription
            public string id { get; set; }
            // Canonical URI of a subscription
            public string uri { get; set; }
            // Collection of URIs to API resources (message-store/presence/detailed presence)
            public string[] eventFilters { get; set; }
            // Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string expirationTime { get; set; }
            // Subscription lifetime in seconds. The default value is 900
            public long? expiresIn { get; set; }
            // Subscription status
            public string status { get; set; }
            // Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string creationTime { get; set; }
            // Delivery mode data
            public DeliveryMode deliveryMode { get; set; }
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
        public partial class PutQueryParams
        {
            // If 'True' then aggregated presence status is returned in a notification payload
            public bool? aggregated { get; set; }
        }
        public partial class PutRequest
        {
            // Collection of URIs to API resources (see Event Types). Mandatory field
            public string[] eventFilters { get; set; }
        }
        public partial class PutResponse
        {
            // Internal identifier of a subscription
            public string id { get; set; }
            // Canonical URI of a subscription
            public string uri { get; set; }
            // Collection of URIs to API resources (message-store/presence/detailed presence)
            public string[] eventFilters { get; set; }
            // Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string expirationTime { get; set; }
            // Subscription lifetime in seconds. The default value is 900
            public long? expiresIn { get; set; }
            // Subscription status
            public string status { get; set; }
            // Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
            public string creationTime { get; set; }
            // Delivery mode data
            public DeliveryMode deliveryMode { get; set; }
        }
    }
}
