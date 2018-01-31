using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DevicesPath : PathSegment
    {
        internal DevicesPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "devices";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Returns the list of paging devices assigned to this group.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<PagingOnlyGroupDevices> List()
        {
            return RC.Get<PagingOnlyGroupDevices>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Returns the list of paging devices assigned to this group.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<PagingOnlyGroupDevices> List(object parameters)
        {
            return RC.Get<PagingOnlyGroupDevices>(Endpoint(false), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.32 (Release 9.3)</p><p>Returns the list of paging devices assigned to this group.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<PagingOnlyGroupDevices> List(ListParameters parameters)
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
    }
}
