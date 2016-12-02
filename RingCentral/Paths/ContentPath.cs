using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ContentPath : PathSegment
    {
        internal ContentPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "content";
            }
        }
        // Get Message Attachment
        public Task<Binary> Get()
        {
            return RC.Get<Binary>(Endpoint(true), null);
        }
    }
}
