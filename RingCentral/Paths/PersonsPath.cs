using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PersonsPath : PathSegment
    {
        internal PersonsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "persons";
            }
        }
        // Returns a user or multiple users by their ID(s). Batch request is supported.
        public Task<GlipPersonInfo> Get()
        {
            return RC.Get<GlipPersonInfo>(Endpoint(true), null);
        }
    }
}
