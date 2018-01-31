using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ProfileImagePath : PathSegment
    {
        internal ProfileImagePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "profile-image";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.20 (Release 7.4)</p><p>Returns the extension profile image.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<Binary> Get()
        {
            return RC.Get<Binary>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.26 (Release 8.2)</p><p>Returns the extension profile image.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<Binary> Post()
        {
            return RC.Post<Binary>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.26 (Release 8.2)</p><p>Updates the extension profile image..</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Heavy</p>
        public Task<Binary> Put()
        {
            return RC.Put<Binary>(Endpoint(true), null);
        }
    }
}
