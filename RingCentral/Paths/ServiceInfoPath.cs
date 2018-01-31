using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServiceInfoPath : PathSegment
    {
        internal ServiceInfoPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "service-info";
            }
        }
        // <p style='font-style:italic;'></p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetServiceInfoResponse> Get()
        {
            return RC.Get<GetServiceInfoResponse>(Endpoint(true), null);
        }
    }
}
