using System.Threading.Tasks;
namespace RingCentral
{
    public partial class ExtensionsPath : PathSegment
    {
        internal ExtensionsPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "extensions";
            }
        }
        // Returns the list of extensions to be recorded.
        public async Task<bool> Get()
        {
            await RC.Get(Endpoint(true), null);
            return true;
        }
    }
}
