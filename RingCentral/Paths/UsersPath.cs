using System.Threading.Tasks;
namespace RingCentral
{
    public partial class UsersPath : PathSegment
    {
        internal UsersPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "Users";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Returns the list of users requested.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GetUserListResponse> Get()
        {
            return RC.Get<GetUserListResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Returns the list of users requested.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GetUserListResponse> Get(object parameters)
        {
            return RC.Get<GetUserListResponse>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Returns the list of users requested.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<GetUserListResponse> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // only support 'userName' or 'email' filter expressions for now
            public string @filter { get; set; }
            // page size
            public long? @count { get; set; }
            // start index (1-based)
            public long? @startIndex { get; set; }
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Creates a user.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserInfo> Post()
        {
            return RC.Post<UserInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Creates a user.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserInfo> Post(object parameters)
        {
            return RC.Post<UserInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p>Creates a user.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Viewing and updating user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserInfo> Post(UserCreationRequest parameters)
        {
            return Post(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Updating User using SCIM</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserInfo> Put()
        {
            return RC.Put<UserInfo>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Updating User using SCIM</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserInfo> Put(object parameters)
        {
            return RC.Put<UserInfo>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Updating User using SCIM</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserInfo> Put(UserUpdateRequest parameters)
        {
            return Put(parameters as object);
        }
        // <p style='font-style:italic;'>Since 1.0.31 (Release 9.2)</p><p></p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditAccounts</td><td>Deleting User using scim</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public async Task<bool> Delete()
        {
            await RC.Delete(Endpoint(true), null);
            return true;
        }
    }
}
