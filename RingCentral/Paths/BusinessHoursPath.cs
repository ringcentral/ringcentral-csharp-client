using System.Threading.Tasks;
namespace RingCentral
{
    public partial class BusinessHoursPath : PathSegment
    {
        internal BusinessHoursPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "business-hours";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.15 (Release 7.0)</p><p>Returns the extension user hours when answering rules are to be applied.</p><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetUserBusinessHoursResponse> Get()
        {
            return RC.Get<GetUserBusinessHoursResponse>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Updates the extension user hours when answering rules are to be applied.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserBusinessHoursUpdate> Put()
        {
            return RC.Put<UserBusinessHoursUpdate>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Updates the extension user hours when answering rules are to be applied.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserBusinessHoursUpdate> Put(object parameters)
        {
            return RC.Put<UserBusinessHoursUpdate>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.28 (Release 8.4)</p><p>Updates the extension user hours when answering rules are to be applied.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating user extension info (includes extension name, number, email and phone number, assigned phone numbers, devices and other extension settings)</td></tr></tbody></table><h4>API Group</h4><p>Medium</p>
        public Task<UserBusinessHoursUpdate> Put(UserBusinessHoursUpdateRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
