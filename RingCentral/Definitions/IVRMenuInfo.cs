namespace RingCentral
{
    public partial class IVRMenuInfo
    {
        // Internal identifier of an IVR Menu extension
        public string @id { get; set; }
        // Link to an IVR Menu extension resource
        public string @uri { get; set; }
        // First name of an IVR Menu user
        public string @name { get; set; }
        // Number of an IVR Menu extension
        public string @extensionNumber { get; set; }
        // Prompt metadata
        public IVRMenuPromptInfo @prompt { get; set; }
        // Keys handling settings
        public IVRMenuActionsInfo[] @actions { get; set; }
    }
}
