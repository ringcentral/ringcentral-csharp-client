using System.Threading.Tasks;
namespace RingCentral
{
    public partial class DevicePath : PathSegment
    {
        internal DevicePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "device";
            }
        }
        // Returns a list of company devices.
        public Task<GetAccountDevicesResponse> List()
        {
            return RC.Get<GetAccountDevicesResponse>(Endpoint(false), null);
        }
        // Returns a list of company devices.
        public Task<GetAccountDevicesResponse> List(object parameters)
        {
            return RC.Get<GetAccountDevicesResponse>(Endpoint(false), parameters);
        }
        // Returns a list of company devices.
        public Task<GetAccountDevicesResponse> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Device serial number
            public string @serial { get; set; }
            // Device feature or multiple features supported
            public string @feature { get; set; }
        }
        // Returns account device(s) by their ID(s).
        public Task<GetDeviceInfoResponse> Get()
        {
            return RC.Get<GetDeviceInfoResponse>(Endpoint(true), null);
        }
        // Updates account device(s) by their ID(s).
        public Task<DeviceResource> Put()
        {
            return RC.Put<DeviceResource>(Endpoint(true), null);
        }
        // Updates account device(s) by their ID(s).
        public Task<DeviceResource> Put(object parameters)
        {
            return RC.Put<DeviceResource>(Endpoint(true), parameters);
        }
        // Updates account device(s) by their ID(s).
        public Task<DeviceResource> Put(AccountDeviceUpdate parameters)
        {
            return Put(parameters as object);
        }
    }
}
