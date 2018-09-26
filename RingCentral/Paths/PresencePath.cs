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
        // Returns presence status of an extension or several extensions by their ID(s). Batch request is supported. The 'presenceStatus' is returned as Offline (the parameters 'telephonyStatus', 'message', 'userStatus' and 'dndStatus' are not returned at all) for the following extension types: Department/Announcement Only/Take Messages Only (Voicemail)/Fax User/Paging Only Group/Shared Lines Group/IVR Menu/Application Extension/Park Location.If the user requests his/her own presence status, the response contains actual presence status even if the status publication is turned off. Batch request is supported. For batch requests the number of extensions in one request is limited to 30. If more extensions are included in the request, the error code 400 Bad Request is returned with the logical error code InvalidMultipartRequest and the corresponding message 'Extension Presence Info multipart request is limited to 30 extensions'.
        public Task<GetPresenceInfo> Get()
        {
            return RC.Get<GetPresenceInfo>(Endpoint(true), null);
        }
        // Returns presence status of an extension or several extensions by their ID(s). Batch request is supported. The 'presenceStatus' is returned as Offline (the parameters 'telephonyStatus', 'message', 'userStatus' and 'dndStatus' are not returned at all) for the following extension types: Department/Announcement Only/Take Messages Only (Voicemail)/Fax User/Paging Only Group/Shared Lines Group/IVR Menu/Application Extension/Park Location.If the user requests his/her own presence status, the response contains actual presence status even if the status publication is turned off. Batch request is supported. For batch requests the number of extensions in one request is limited to 30. If more extensions are included in the request, the error code 400 Bad Request is returned with the logical error code InvalidMultipartRequest and the corresponding message 'Extension Presence Info multipart request is limited to 30 extensions'.
        public Task<GetPresenceInfo> Get(object parameters)
        {
            return RC.Get<GetPresenceInfo>(Endpoint(true), parameters);
        }
        // Returns presence status of an extension or several extensions by their ID(s). Batch request is supported. The 'presenceStatus' is returned as Offline (the parameters 'telephonyStatus', 'message', 'userStatus' and 'dndStatus' are not returned at all) for the following extension types: Department/Announcement Only/Take Messages Only (Voicemail)/Fax User/Paging Only Group/Shared Lines Group/IVR Menu/Application Extension/Park Location.If the user requests his/her own presence status, the response contains actual presence status even if the status publication is turned off. Batch request is supported. For batch requests the number of extensions in one request is limited to 30. If more extensions are included in the request, the error code 400 Bad Request is returned with the logical error code InvalidMultipartRequest and the corresponding message 'Extension Presence Info multipart request is limited to 30 extensions'.
        public Task<GetPresenceInfo> Get(GetParameters parameters)
        {
            return Get(parameters as object);
        }
        public partial class GetParameters
        {
            // Whether to return detailed telephony state
            public bool? @detailedTelephonyState { get; set; }
            // Whether to return SIP data
            public bool? @sipData { get; set; }
        }
        // Updates user-defined extension presence status, status message and DnD status by extension ID. Supported for regular User extensions only. The extension types listed do not support presence status: Department, Announcement Only, Take Messages Only (Voicemail), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.
        public Task<PresenceInfoResource> Put()
        {
            return RC.Put<PresenceInfoResource>(Endpoint(true), null);
        }
        // Updates user-defined extension presence status, status message and DnD status by extension ID. Supported for regular User extensions only. The extension types listed do not support presence status: Department, Announcement Only, Take Messages Only (Voicemail), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.
        public Task<PresenceInfoResource> Put(object parameters)
        {
            return RC.Put<PresenceInfoResource>(Endpoint(true), parameters);
        }
        // Updates user-defined extension presence status, status message and DnD status by extension ID. Supported for regular User extensions only. The extension types listed do not support presence status: Department, Announcement Only, Take Messages Only (Voicemail), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.
        public Task<PresenceInfoResource> Put(PresenceInfoResource parameters)
        {
            return Put(parameters as object);
        }
        // Returns presence status of all extensions of an account. Please note: The presenceStatus is returned as Offline (the parameters telephonyStatus, message, userStatus and dndStatus are not returned at all) for the following extension types: Department, Announcement Only, Voicemail (Take Messages Only), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.
        public Task<AccountPresenceInfo> List()
        {
            return RC.Get<AccountPresenceInfo>(Endpoint(false), null);
        }
        // Returns presence status of all extensions of an account. Please note: The presenceStatus is returned as Offline (the parameters telephonyStatus, message, userStatus and dndStatus are not returned at all) for the following extension types: Department, Announcement Only, Voicemail (Take Messages Only), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.
        public Task<AccountPresenceInfo> List(object parameters)
        {
            return RC.Get<AccountPresenceInfo>(Endpoint(false), parameters);
        }
        // Returns presence status of all extensions of an account. Please note: The presenceStatus is returned as Offline (the parameters telephonyStatus, message, userStatus and dndStatus are not returned at all) for the following extension types: Department, Announcement Only, Voicemail (Take Messages Only), Fax User, Paging Only Group, Shared Lines Group, IVR Menu, Application Extension.
        public Task<AccountPresenceInfo> List(ListParameters parameters)
        {
            return List(parameters as object);
        }
        public partial class ListParameters
        {
            // Whether to return detailed telephony state
            public bool? @detailedTelephonyState { get; set; }
            // Whether to return SIP data
            public bool? @sipData { get; set; }
            // Page number for accoount presence information
            public long? @page { get; set; }
            // Number for accoount presence information items per page
            public long? @perPage { get; set; }
        }
    }
}
