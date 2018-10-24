using System.Threading.Tasks;
namespace RingCentral
{
    public partial class AuthorizePath : PathSegment
    {
        internal AuthorizePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "authorize";
            }
        }
        // Returns link to a login page location.
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
    }
}
