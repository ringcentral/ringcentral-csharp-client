using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ProfileImagePath : Model
    {
        internal ProfileImagePath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
