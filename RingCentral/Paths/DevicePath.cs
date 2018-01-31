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
        // <p style='font-style:italic;'>Since 1.0.12 (Release 6.4)</p><p>Returns all the devices for a particular extension.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetAccountDevicesResponse> List()
        {
            return RC.Get<GetAccountDevicesResponse>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.9 (Release 6.1)</p><p>Returns account device(s) by their ID(s).</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadAccounts</td><td>Viewing user account info (including name, business name, address and phone number/account number)</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetDeviceInfoResponse> Get()
        {
            return RC.Get<GetDeviceInfoResponse>(Endpoint(true), null);
        }
        //
        public Task<DeviceResource> Put()
        {
            return RC.Put<DeviceResource>(Endpoint(true), null);
        }
        //
        public Task<DeviceResource> Put(object parameters)
        {
            return RC.Put<DeviceResource>(Endpoint(true), parameters);
        }
        //
        public Task<DeviceResource> Put(AccountDeviceUpdate parameters)
        {
            return Put(parameters as object);
        }
    }
}
