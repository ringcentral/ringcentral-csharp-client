using System.Threading.Tasks;
namespace RingCentral
{
    public partial class OauthPath : Model
    {
        internal OauthPath(Model parent, string _id = null) : base(parent, _id) { }
        protected override string PathSegment
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
        public RevokePath Revoke()
        {
            return new RevokePath(this);
        }
        public TokenPath Token()
        {
            return new TokenPath(this);
        }
    }
}
