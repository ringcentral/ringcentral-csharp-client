namespace RingCentral
{
    public partial class DictionaryGreetingInfo
    {
        // Internal identifier of a greeting
        public string @id { get; set; }
        // Link to a greeting
        public string @uri { get; set; }
        // Name of a greeting
        public string @name { get; set; }
        // Usage type of a greeting, specifying if the greeting is applied for user extension or department extension = ['UserExtensionAnsweringRule', 'ExtensionAnsweringRule', 'DepartmentExtensionAnsweringRule', 'CompanyAnsweringRule', 'CompanyAfterHoursAnsweringRule']
        public string @usageType { get; set; }
        // Text of a greeting, if any
        public string @text { get; set; }
        // Link to a greeting content (audio file), if any
        public string @contentUri { get; set; }
        // Type of a greeting, specifying the case when the greeting is played. See Greeting Types = ['Introductory', 'Announcement', 'ConnectingMessage', 'ConnectingAudio', 'Voicemail', 'Unavailable', 'InterruptPrompt', 'HoldMusic', 'Company']
        public string @type { get; set; }
        // Category of a greeting, specifying data form. The category value 'None' specifies that greetings of a certain type ('Introductory', 'ConnectingAudio', etc.) are switched off for an extension = ['Music', 'Message', 'Ring Tones', 'None']
        public string @category { get; set; }
        // Information on navigation
        public NavigationInfo @navigation { get; set; }
        // Information on paging
        public PagingInfo @paging { get; set; }
    }
}
