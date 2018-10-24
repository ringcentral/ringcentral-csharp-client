using System.Threading.Tasks;
namespace RingCentral
{
    public partial class OauthPath : PathSegment
    {
        internal OauthPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "oauth";
            }
        }
        public AuthorizePath Authorize()
        {
            return new AuthorizePath(this);
        }
        public TokenPath Token()
        {
            return new TokenPath(this);
        }
        public RevokePath Revoke()
        {
            return new RevokePath(this);
        }
    }
}
