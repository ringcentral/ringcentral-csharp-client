namespace RingCentral
{
    public partial class ExtensionInfo_Request_StatusInfo
    {
        // Required extension status
        public string @status { get; set; }
        // Extension status information, only for the 'Disabled' status
        public StatusInfo @statusInfo { get; set; }
    }
}
