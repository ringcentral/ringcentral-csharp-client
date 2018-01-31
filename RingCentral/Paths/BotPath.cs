using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BotPath : PathSegment
    {
        internal BotPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "bot";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Creates a bot extension. Please note: Bot extension is always created in Enabled status, no welcome email is sent.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<BotExtensionCreation> Post()
        {
            return RC.Post<BotExtensionCreation>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Creates a bot extension. Please note: Bot extension is always created in Enabled status, no welcome email is sent.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<BotExtensionCreation> Post(object parameters)
        {
            return RC.Post<BotExtensionCreation>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Creates a bot extension. Please note: Bot extension is always created in Enabled status, no welcome email is sent.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<BotExtensionCreation> Post(BotExtensionCreationRequest parameters)
        {
            return Post(parameters as object);
        }
    }
}
