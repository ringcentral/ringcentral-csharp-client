namespace RingCentral
{
    public partial class ExtensionUpdateRequest
    {
        //
        public string @status { get; set; }
        //
        public ExtensionStatusInfo @statusInfo { get; set; }
        // Type of suspension
        public string @reason { get; set; }
        // Free Form user comment
        public string @comment { get; set; }
        // Extension number available
        public string @extensionNumber { get; set; }
        //
        public ContactInfoUpdateRequest @contact { get; set; }
        //
        public ExtensionRegionalSettingRequest @regionalSettings { get; set; }
        //
        public string @setupWizardState { get; set; }
        //  Extension partner identifier
        public string @partnerId { get; set; }
        // IVR PIN
        public string @ivrPin { get; set; }
        // Password for extension
        public string @password { get; set; }
        // For Department extension type only. Call queue settings
        public CallQueueInfoRequest @callQueueInfo { get; set; }
        // For NotActivated extensions only. Welcome email setting
        public string @transition { get; set; }
    }
}
