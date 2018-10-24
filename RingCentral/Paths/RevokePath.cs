using System.Threading.Tasks;
namespace RingCentral
{
    public partial class RevokePath : PathSegment
    {
        internal RevokePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "revoke";
            }
        }
        // Revokes access/refresh token. Requests to this endpoint must be authenticated with HTTP Basic scheme using the application key and application secret as login and password, correspondingly.
        public async Task<bool> Post()
        {
            await RC.Post(Endpoint(true), null);
            return true;
        }
    }
}
