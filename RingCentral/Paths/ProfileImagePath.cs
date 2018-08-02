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
        // Returns a profile image of an extension.
        public Task<Binary> Get()
        {
            return RC.Get<Binary>(Endpoint(true), null);
        }
        // Returns the extension profile image.
        public Task<Binary> Post()
        {
            return RC.Post<Binary>(Endpoint(true), null);
        }
        // Updates profile image of an extension.
        public Task<Binary> Put()
        {
            return RC.Put<Binary>(Endpoint(true), null);
        }
    }
}
