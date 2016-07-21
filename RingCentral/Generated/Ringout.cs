
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class Ringout : Model
    {
        internal Ringout(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
        {
            get
            {
                return "ringout";
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
            public To to { get; set; }
            public CallerId callerId { get; set; }
            public bool? playPrompt { get; set; }
            public Country country { get; set; }
            public class From
            {
                public string phoneNumber { get; set; }
                public string forwardingNumberId { get; set; }
            }
            public class To
            {
                public string phoneNumber { get; set; }
            }
            public class CallerId
            {
                public string phoneNumber { get; set; }
            }
            public class Country
            {
                public string id { get; set; }
            }
        }
        public class PostResponse
        {
            public string id { get; set; }
            public Status status { get; set; }
            public class Status
            {
                public string callStatus { get; set; }
                public string callerStatus { get; set; }
                public string calleeStatus { get; set; }
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
            public Status status { get; set; }
            public class Status
            {
                public string callStatus { get; set; }
                public string callerStatus { get; set; }
                public string calleeStatus { get; set; }
            }
        }
    }
}
