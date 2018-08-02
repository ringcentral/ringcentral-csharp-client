using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallerBlockingPath : PathSegment
    {
        internal CallerBlockingPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "caller-blocking";
            }
        }
        public PhoneNumbersPath PhoneNumbers(string _id)
        {
            return new PhoneNumbersPath(this, _id);
        }
        public PhoneNumbersPath PhoneNumbers()
        {
            return new PhoneNumbersPath(this);
        }
        // Returns the current call blocking settings of a user.
        public Task<CallerBlockingSettings> Get()
        {
            return RC.Get<CallerBlockingSettings>(Endpoint(true), null);
        }
        // Updates the current call blocking settings of a user.
        public Task<CallerBlockingSettings> Put()
        {
            return RC.Put<CallerBlockingSettings>(Endpoint(true), null);
        }
        // Updates the current call blocking settings of a user.
        public Task<CallerBlockingSettings> Put(object parameters)
        {
            return RC.Put<CallerBlockingSettings>(Endpoint(true), parameters);
        }
        // Updates the current call blocking settings of a user.
        public Task<CallerBlockingSettings> Put(CallerBlockingSettingsUpdate parameters)
        {
            return Put(parameters as object);
        }
    }
}
