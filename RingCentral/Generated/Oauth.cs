
namespace RingCentral
{
    public partial class Oauth : Model
    {
        internal Oauth(Model parent) : base(parent, null) { }
        protected override string PathSegment
        {
            get
            {
                return "oauth";
            }
        }
        public Authorize Authorize()
        {
            return new Authorize(this);
        }
        public Revoke Revoke()
        {
            return new Revoke(this);
        }
        public Token Token()
        {
            return new Token(this);
        }
    }
}
