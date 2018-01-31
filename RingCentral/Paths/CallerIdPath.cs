using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallerIdPath : PathSegment
    {
        internal CallerIdPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "caller-id";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Returns information on an outbound caller ID of an extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Light</p>
        public Task<ExtensionCallerIdInfo> Get()
        {
            return RC.Get<ExtensionCallerIdInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Updates outbound caller ID information of an extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ExtensionCallerIdInfo> Put()
        {
            return RC.Put<ExtensionCallerIdInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Updates outbound caller ID information of an extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ExtensionCallerIdInfo> Put(object parameters)
        {
            return RC.Put<ExtensionCallerIdInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Updates outbound caller ID information of an extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ExtensionCallerIdInfo> Put(ExtensionCallerIdInfo parameters)
        {
            return Put(parameters as object);
        }
    }
}
