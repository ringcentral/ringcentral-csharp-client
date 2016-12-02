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
        // Get Profile Image
        public Task<Binary> Get()
        {
            return RC.Get<Binary>(Endpoint(true), null);
        }
    }
}
