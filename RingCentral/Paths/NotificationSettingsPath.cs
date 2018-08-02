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
        // Returns notification settings for the current extension.
        public Task<NotificationSettings> Get()
        {
            return RC.Get<NotificationSettings>(Endpoint(true), null);
        }
        // Updates notification settings for the current extension.
        public Task<NotificationSettings> Put()
        {
            return RC.Put<NotificationSettings>(Endpoint(true), null);
        }
        // Updates notification settings for the current extension.
        public Task<NotificationSettings> Put(object parameters)
        {
            return RC.Put<NotificationSettings>(Endpoint(true), parameters);
        }
        // Updates notification settings for the current extension.
        public Task<NotificationSettings> Put(NotificationSettingsUpdateRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
