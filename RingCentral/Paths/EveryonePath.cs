using System.Threading.Tasks;
namespace RingCentral
{
    public partial class EveryonePath : PathSegment
    {
        internal EveryonePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "everyone";
            }
        }
        // Returns information about Everyone chat.
        public Task<GlipEveryoneInfo> Get()
        {
            return RC.Get<GlipEveryoneInfo>(Endpoint(true), null);
        }
    }
}
