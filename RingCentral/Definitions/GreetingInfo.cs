namespace RingCentral
{
    public partial class GreetingInfo
    {
        // Type of a greeting, specifying the case when the greeting is played. See Greeting Types = ['Introductory', 'Announcement', 'ConnectingMessage', 'ConnectingAudio', 'Voicemail', 'Unavailable', 'InterruptPrompt', 'HoldMusic']
        public string @type { get; set; }
        // Usage type of a greeting, specifying if the greeting is applied to user extension or department extension = ['UserExtensionAnsweringRule', 'ExtensionAnsweringRule DepartmentExtensionAnsweringRule']
        public string @usageType { get; set; }
        //
        public PresetInfo @preset { get; set; }
    }
}
