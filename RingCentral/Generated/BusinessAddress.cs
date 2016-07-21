
using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BusinessAddress : Model
    {
        internal BusinessAddress(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "business-address";
            }
        }
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(false), null);
        }
        public class GetResponse
        {
            public string uri { get; set; }
            public string company { get; set; }
            public string email { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public class PutRequest
        {
            public string company { get; set; }
            public string email { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
        }
        public class PutResponse
        {
            public string uri { get; set; }
            public string company { get; set; }
            public string email { get; set; }
            public BusinessAddress businessAddress { get; set; }
            public class BusinessAddress
            {
                public string country { get; set; }
                public string state { get; set; }
                public string city { get; set; }
                public string street { get; set; }
                public string zip { get; set; }
            }
        }
    }
}
