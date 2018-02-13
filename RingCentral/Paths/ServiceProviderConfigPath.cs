using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ServiceProviderConfigPath : PathSegment
    {
        internal ServiceProviderConfigPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "ServiceProviderConfig";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Returns the list of users requested.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing Service Provider confiog</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ServiceProviderConfig> Get()
        {
            return RC.Get<ServiceProviderConfig>(Endpoint(true), null);
        }
    }
}
