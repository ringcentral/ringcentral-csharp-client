using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ScimPath : PathSegment
    {
        internal ScimPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "scim";
            }
        }
        public ServiceProviderConfigPath ServiceProviderConfig()
        {
            return new ServiceProviderConfigPath(this);
        }
        public UsersPath Users(string _id)
        {
            return new UsersPath(this, _id);
        }
        public UsersPath Users()
        {
            return new UsersPath(this);
        }
    }
}
