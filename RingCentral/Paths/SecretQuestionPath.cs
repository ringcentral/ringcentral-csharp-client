using System.Threading.Tasks;
namespace RingCentral
{
    public partial class SecretQuestionPath : PathSegment
    {
        internal SecretQuestionPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "secret-question";
            }
        }
    }
}
