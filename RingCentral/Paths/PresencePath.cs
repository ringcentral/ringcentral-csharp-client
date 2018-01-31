using System.Threading.Tasks;
namespace RingCentral
{
    public partial class PresencePath : PathSegment
    {
        internal PresencePath(PathSegment parent, string _id = null) : base(parent, _id) { }
        protected override string Segment
        {
            get
            {
                return "presence";
            }
        }
        public LinePath Line(string _id)
        {
            return new LinePath(this, _id);
        }
        public LinePath Line()
        {
            return new LinePath(this);
        }
        public PermissionPath Permission(string _id)
        {
            return new PermissionPath(this, _id);
        }
        public PermissionPath Permission()
        {
            return new PermissionPath(this);
        }
        //
        public Task<AccountPresenceInfo> List()
        {
            return RC.Get<AccountPresenceInfo>(Endpoint(false), null);
        }
        // <p style='font-style:italic;'>Since 1.0.2</p><p>Returns presence status of an extension or several extensions by their ID(s). Batch request is supported, see Batch Requests for details.The presenceStatus is returned as Offline (the parameters telephonyStatus, message, userStatus and dndStatus are not returned at all) for the following extension types: Department/Announcement Only/Take Messages Only (Voicemail)/Fax User/Paging Only Group/Shared Lines Group/IVR Menu/Application Extension/Park Location.If the user requests his/her own presence status, the response contains actual presence status even if the status publication is turned off.Batch request is supported. For batch requests the number of extensions in one request is limited to 30. If more extensions are included in the request, the error code 400 Bad Request is returned with the logical error code InvalidMultipartRequest and the corresponding message 'Extension Presence Info multipart request is limited to 30 extensions'.</p><h4>Required Permissions</h4><table class='fullwidth'><thead><tr><th>Permission</th><th>Description</th></tr></thead><tbody><tr><td class='code'>ReadPresence</td><td>Getting user presence information</td></tr></tbody></table><h4>Usage Plan Group</h4><p>Light</p>
        public Task<GetPresenceInfo> Get()
        {
            return RC.Get<GetPresenceInfo>(Endpoint(true), null);
        }
        //
        public Task<PresenceInfoResource> Put()
        {
            return RC.Put<PresenceInfoResource>(Endpoint(true), null);
        }
        //
        public Task<PresenceInfoResource> Put(object parameters)
        {
            return RC.Put<PresenceInfoResource>(Endpoint(true), parameters);
        }
        //
        public Task<PresenceInfoResource> Put(PresenceInfoResource parameters)
        {
            return Put(parameters as object);
        }
    }
}
