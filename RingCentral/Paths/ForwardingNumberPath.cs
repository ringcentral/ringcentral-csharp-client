using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ForwardingNumberPath : PathSegment
    {
        internal ForwardingNumberPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "forwarding-number";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.7 (Release 5.16)</p><p>Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers that are used for call forwarding and call flip.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetExtensionForwardingNumberListResponse> List()
        {
            return RC.Get<GetExtensionForwardingNumberListResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.7 (Release 5.16)</p><p>Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers that are used for call forwarding and call flip.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetExtensionForwardingNumberListResponse> List(object parameters)
        {
            return RC.Get<GetExtensionForwardingNumberListResponse>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.7 (Release 5.16)</p><p>Returns the list of extension phone numbers used for call forwarding and call flip. The returned list contains all the extension phone numbers that are used for call forwarding and call flip.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetExtensionForwardingNumberListResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). If not specified, the value is '100' by default
            public long? @perPage { get; set; }
        }
        // <p style='font-style:italic;'>Since 1.0.12 (Release 6.4)</p><p>Adds a new forwarding number to the forwarding number list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<ForwardingNumberInfo> Post()
        {
            return RC.Post<ForwardingNumberInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.12 (Release 6.4)</p><p>Adds a new forwarding number to the forwarding number list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<ForwardingNumberInfo> Post(object parameters)
        {
            return RC.Post<ForwardingNumberInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.12 (Release 6.4)</p><p>Adds a new forwarding number to the forwarding number list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<ForwardingNumberInfo> Post(CreateForwardingNumberRequest parameters)
        {
            return Post(parameters as object);
        }
        //
        public Task<ForwardingNumberResource> Get()
        {
            return RC.Get<ForwardingNumberResource>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.24 (Release 8.0)</p><p>Updates an existent forwarding number from the forwarding number list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<ForwardingNumberInfo> Put()
        {
            return RC.Put<ForwardingNumberInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.24 (Release 8.0)</p><p>Updates an existent forwarding number from the forwarding number list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<ForwardingNumberInfo> Put(object parameters)
        {
            return RC.Put<ForwardingNumberInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.24 (Release 8.0)</p><p>Updates an existent forwarding number from the forwarding number list.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<ForwardingNumberInfo> Put(UpdateForwardingNumberRequest parameters)
        {
            return Put(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.24 (Release 8.0)</p><p>Deletes a forwarding number from the forwarding number list by its ID.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
