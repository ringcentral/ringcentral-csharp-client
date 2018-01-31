using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ValidatePath : PathSegment
    {
        internal ValidatePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "validate";
            }
        }
    }
}
