using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CredentialsPath : PathSegment
    {
        internal CredentialsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "credentials";
            }
        }
        public ValidatePath Validate()
        {
            return new ValidatePath(this);
        }
        public VerifyPath Verify()
        {
            return new VerifyPath(this);
        }
    }
}
