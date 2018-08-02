using System.Threading.Tasks;
namespace RingCentral
{
    public partial class IvrMenusPath : PathSegment
    {
        internal IvrMenusPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "ivr-menus";
            }
        }
        // Returns a company IVR menu by ID.
        public Task<IVRMenuInfo> Get()
        {
            return RC.Get<IVRMenuInfo>(Endpoint(true), null);
        }
    }
}
