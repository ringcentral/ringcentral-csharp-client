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
        // Creates a company IVR menu.
        public Task<IVRMenuInfo> Post()
        {
            return RC.Post<IVRMenuInfo>(Endpoint(true), null);
        }
        // Creates a company IVR menu.
        public Task<IVRMenuInfo> Post(object parameters)
        {
            return RC.Post<IVRMenuInfo>(Endpoint(true), parameters);
        }
        // Creates a company IVR menu.
        public Task<IVRMenuInfo> Post(IVRMenuInfo parameters)
        {
            return Post(parameters as object);
        }
        // Returns a company IVR menu by ID.
        public Task<IVRMenuInfo> Get()
        {
            return RC.Get<IVRMenuInfo>(Endpoint(true), null);
        }
        // Returns a company IVR menu by ID.
        public Task<IVRMenuInfo> Put()
        {
            return RC.Put<IVRMenuInfo>(Endpoint(true), null);
        }
        // Returns a company IVR menu by ID.
        public Task<IVRMenuInfo> Put(object parameters)
        {
            return RC.Put<IVRMenuInfo>(Endpoint(true), parameters);
        }
        // Returns a company IVR menu by ID.
        public Task<IVRMenuInfo> Put(IVRMenuInfo parameters)
        {
            return Put(parameters as object);
        }
    }
}
