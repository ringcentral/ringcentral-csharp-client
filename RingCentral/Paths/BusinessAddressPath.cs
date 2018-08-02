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
        // Returns business address of a company.
        public Task<GetAccountInfoResponse> Get()
        {
            return RC.Get<GetAccountInfoResponse>(Endpoint(true), null);
        }
        // Updates the business address of a company that account is linked to. Batch request is supported.
        public Task<AccountBusinessAddressResource> Put()
        {
            return RC.Put<AccountBusinessAddressResource>(Endpoint(true), null);
        }
        // Updates the business address of a company that account is linked to. Batch request is supported.
        public Task<AccountBusinessAddressResource> Put(object parameters)
        {
            return RC.Put<AccountBusinessAddressResource>(Endpoint(true), parameters);
        }
        // Updates the business address of a company that account is linked to. Batch request is supported.
        public Task<AccountBusinessAddressResource> Put(ModifyAccountBusinessAddressRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
