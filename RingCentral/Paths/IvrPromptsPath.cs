using System.Threading.Tasks;
namespace RingCentral
{
    public partial class IvrPromptsPath : PathSegment
    {
        internal IvrPromptsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "ivr-prompts";
            }
        }
        public ContentPath Content(string _id)
        {
            return new ContentPath(this, _id);
        }
        public ContentPath Content()
        {
            return new ContentPath(this);
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Returns a list of IVR prompts.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<IVRPrompts> List()
        {
            return RC.Get<IVRPrompts>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Returns an IVR prompt by ID</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<PromptInfo> Get()
        {
            return RC.Get<PromptInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Deletes an IVR prompt by ID</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Heavy</p>
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
