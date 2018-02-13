namespace RingCentral
{
    public partial class ExtensionResourceIntId
    {
        //
        public string @uri { get; set; }
        //
        public long? @id { get; set; }
        //
        public string @partnerId { get; set; }
        //
        public string @extensionNumber { get; set; }
        //
        public string @loginName { get; set; }
        //
        public ContactInfo @contact { get; set; }
        //
        public Reference[] @references { get; set; }
        //
        public string @name { get; set; }
        //
        public string @type { get; set; }
        //
        public string @status { get; set; }
        //
        public StatusInfo @statusInfo { get; set; }
        //
        public DepartmentResource[] @departments { get; set; }
        //
        public ServiceFeatureValue[] @serviceFeatures { get; set; }
        //
        public RegionalSettingsResource @regionalSettings { get; set; }
        //
        public string @setupWizardState { get; set; }
        //
        public ExtensionPermissionsResource @permissions { get; set; }
        //
        public string @password { get; set; }
        //
        public string @ivrPin { get; set; }
        //
        public ProfileImageResource @profileImage { get; set; }
    }
}
