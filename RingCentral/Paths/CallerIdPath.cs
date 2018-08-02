using System.Threading.Tasks;
namespace RingCentral
{
    public partial class CallerIdPath : PathSegment
    {
        internal CallerIdPath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "caller-id";
            }
        }
        // Returns information on an outbound caller ID of an extension.
        public Task<ExtensionCallerIdInfo> Get()
        {
            return RC.Get<ExtensionCallerIdInfo>(Endpoint(true), null);
        }
        // Updates outbound caller ID information of an extension.
        public Task<ExtensionCallerIdInfo> Put()
        {
            return RC.Put<ExtensionCallerIdInfo>(Endpoint(true), null);
        }
        // Updates outbound caller ID information of an extension.
        public Task<ExtensionCallerIdInfo> Put(object parameters)
        {
            return RC.Put<ExtensionCallerIdInfo>(Endpoint(true), parameters);
        }
        // Updates outbound caller ID information of an extension.
        public Task<ExtensionCallerIdInfo> Put(ExtensionCallerIdInfo parameters)
        {
            return Put(parameters as object);
        }
    }
}
