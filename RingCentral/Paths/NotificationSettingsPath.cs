using System.Threading.Tasks;
namespace RingCentral
{
    public partial class NotificationSettingsPath : PathSegment
    {
        internal NotificationSettingsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "notification-settings";
            }
        }
        // <p style='font-style:italic;'>Since 1.0.26 (Release 8.2)</p><p>Returns notification settings for the current extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<NotificationSettings> Get()
        {
            return RC.Get<NotificationSettings>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.26 (Release 8.2)</p><p>Updates notification settings for the current extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<NotificationSettings> Put()
        {
            return RC.Put<NotificationSettings>(Endpoint(true), null);
        }
        // <p style='font-style:italic;'>Since 1.0.26 (Release 8.2)</p><p>Updates notification settings for the current extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<NotificationSettings> Put(object parameters)
        {
            return RC.Put<NotificationSettings>(Endpoint(true), parameters);
        }
        // <p style='font-style:italic;'>Since 1.0.26 (Release 8.2)</p><p>Updates notification settings for the current extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>EditExtensions</td><td>Viewing and updating my extension info (includes extension name, number, email and phone number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Medium</p>
        public Task<NotificationSettings> Put(NotificationSettingsUpdateRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
