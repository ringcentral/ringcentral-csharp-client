
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
        public partial class GetResponse
        {
            // Canonical URI of the business address resource
            public string uri { get; set; }
            // Company business name
            public string company { get; set; }
            // Company business email address
            public string email { get; set; }
            // Company business address
            public BusinessAddressInfo businessAddress { get; set; }
        }
        public Task<PutResponse> Put(object requestBody)
        {
            return RC.Put<PutResponse>(Endpoint(false), requestBody, null);
        }
        public Task<PutResponse> Put(PutRequest requestBody)
        {
            return Put(requestBody as object);
        }
        public partial class PutRequest
        {
            // Company business name
            public string company { get; set; }
            // Company business email address
            public string email { get; set; }
            // Company business address
            public BusinessAddressInfo businessAddress { get; set; }
        }
        public partial class PutResponse
        {
            // Canonical URI of the business address resource
            public string uri { get; set; }
            // Company business name
            public string company { get; set; }
            // Company business email address
            public string email { get; set; }
            // Company business address
            public BusinessAddressInfo businessAddress { get; set; }
        }
    }
}
