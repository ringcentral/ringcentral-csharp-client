namespace RingCentral
{
    public partial class GetExtensionInfoResponse
    {
        // Internal identifier of an extension
        public string @id { get; set; }
        // Canonical URI of an extension
        public string @uri { get; set; }
        // Contact detailed information
        public ContactInfo @contact { get; set; }
        // Information on department extension(s), to which the requested extension belongs. Returned only for user extensions, members of department, requested by single extensionId
        public DepartmentInfo[] @departments { get; set; }
        // Number of department extension
        public string @extensionNumber { get; set; }
        // Extension user name
        public string @name { get; set; }
        // For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
        public string @partnerId { get; set; }
        // Extension permissions, corresponding to the Service Web permissions 'Admin' and 'InternationalCalling'
        public ExtensionPermissions @permissions { get; set; }
        // Information on profile image
        public ProfileImageInfo @profileImage { get; set; }
        // List of non-RC internal identifiers assigned to an extension
        public ReferenceInfo[] @references { get; set; }
        // Extension region data (timezone, home country, language)
        public RegionalSettings @regionalSettings { get; set; }
        // Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features
        public ExtensionServiceFeatureInfo[] @serviceFeatures { get; set; }
        // Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
        public string @setupWizardState { get; set; }
        // Extension current state. If the status is 'Unassigned'. Returned for all extensions
        public string @status { get; set; }
        // Status information (reason, comment). Returned for 'Disabled' status only
        public ExtensionStatusInfo @statusInfo { get; set; }
        // Extension type
        public string @type { get; set; }
        // For Department extension type only. Call queue settings
        public CallQueueInfo @callQueueInfo { get; set; }
    }
}
