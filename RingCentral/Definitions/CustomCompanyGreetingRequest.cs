namespace RingCentral
{
    public partial class CustomCompanyGreetingRequest
    {
        // Type of a greeting, specifying the case when the greeting is played. See Greeting Types = ['Introductory', 'Announcement', 'ConnectingMessage', 'ConnectingAudio', 'Voicemail', 'Unavailable', 'HoldMusic']
        public string @type { get; set; }
        // nformation on an answering rule that the greeting is applied to
        public CustomCompanyGreetingAnsweringRuleInfo @answeringRule { get; set; }
    }
}
