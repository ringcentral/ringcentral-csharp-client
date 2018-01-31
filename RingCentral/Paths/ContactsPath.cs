using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ContactsPath : PathSegment
    {
        internal ContactsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "contacts";
            }
        }
        // <p style='font-style:italic;'></p><p>Returns contact information on corporate users of federated accounts. Please note: 1. User, DigitalUser, VirtualUser and FaxUser types are returned as User type. 2.ApplicationExtension type is not returned. 3. Only extensions in Enabled, Disabled and NotActivated state are returned.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<CompanyDirectoryContacts> List()
        {
            return RC.Get<CompanyDirectoryContacts>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'></p><p>Returns contact information on corporate users of federated accounts. Please note: 1. User, DigitalUser, VirtualUser and FaxUser types are returned as User type. 2.ApplicationExtension type is not returned. 3. Only extensions in Enabled, Disabled and NotActivated state are returned.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<CompanyDirectoryContacts> List(object parameters)
        {
            return RC.Get<CompanyDirectoryContacts>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'></p><p>Returns contact information on corporate users of federated accounts. Please note: 1. User, DigitalUser, VirtualUser and FaxUser types are returned as User type. 2.ApplicationExtension type is not returned. 3. Only extensions in Enabled, Disabled and NotActivated state are returned.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<CompanyDirectoryContacts> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
            public long? @page { get; set; }
            // Indicates the page size (number of items). The possible values are: Max, all or a numeric value. If not specified, all records are returned on one page
            public long? @perPage { get; set; }
            // If 'True' then only contacts of current account are returned, if 'False' then all contacts of all federation accounts are returned
            public bool? @excludeFederatedContacts { get; set; }
        }
        // <p style='font-style:italic;'></p><p>Returns contact information on a particular corporate user of a federated account.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<ContactInfo> Get()
        {
            return RC.Get<ContactInfo>(Endpoint(true), null);
        }
    }
}
