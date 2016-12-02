using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BusinessAddressPath : PathSegment
    {
        internal BusinessAddressPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "business-address";
            }
        }
        // Get Company Business Address
        public Task<GetResponse> Get()
        {
            return RC.Get<GetResponse>(Endpoint(true), null);
        }
        public partial class GetResponse
        {
            // Canonical URI of the business address resource
            public string @uri { get; set; }
            // Company business name
            public string @company { get; set; }
            // Company business email address
            public string @email { get; set; }
            // Company business address
            public BusinessAddressInfo @businessAddress { get; set; }
        }
        // Update Company Business Address
        public Task<PutResponse> Put()
        {
            return RC.Put<PutResponse>(Endpoint(true), null);
        }
        // Update Company Business Address
        public Task<PutResponse> Put(object parameters)
        {
            return RC.Put<PutResponse>(Endpoint(true), parameters);
        }
        // Update Company Business Address
        public Task<PutResponse> Put(PutParameters parameters)
        {
            return Put(parameters as object);
        }
        public partial class PutParameters
        {
            // Company business name
            public string @company { get; set; }
            // Company business email address
            public string @email { get; set; }
            // Company business address
            public BusinessAddressInfo @businessAddress { get; set; }
        }
        public partial class PutResponse
        {
            // Canonical URI of the business address resource
            public string @uri { get; set; }
            // Company business name
            public string @company { get; set; }
            // Company business email address
            public string @email { get; set; }
            // Company business address
            public BusinessAddressInfo @businessAddress { get; set; }
        }
    }
}
