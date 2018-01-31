using System.Threading.Tasks;
namespace RingCentral
{
    public partial class FederationPath : PathSegment
    {
        internal FederationPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "federation";
            }
        }
        // <p style='font-style:italic;'></p><p>Returns information on a federation and associated accounts.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<FederationInfo> Get()
        {
            return RC.Get<FederationInfo>(Endpoint(true), null);
        }
    }
}
