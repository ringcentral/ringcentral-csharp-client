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
        // Returns the extension user hours when answering rules are to be applied.
        public Task<GetUserBusinessHoursResponse> Get()
        {
            return RC.Get<GetUserBusinessHoursResponse>(Endpoint(true), null);
        }
        // Updates the extension user hours when answering rules are to be applied.
        public Task<UserBusinessHoursUpdate> Put()
        {
            return RC.Put<UserBusinessHoursUpdate>(Endpoint(true), null);
        }
        // Updates the extension user hours when answering rules are to be applied.
        public Task<UserBusinessHoursUpdate> Put(object parameters)
        {
            return RC.Put<UserBusinessHoursUpdate>(Endpoint(true), parameters);
        }
        // Updates the extension user hours when answering rules are to be applied.
        public Task<UserBusinessHoursUpdate> Put(UserBusinessHoursUpdateRequest parameters)
        {
            return Put(parameters as object);
        }
    }
}
