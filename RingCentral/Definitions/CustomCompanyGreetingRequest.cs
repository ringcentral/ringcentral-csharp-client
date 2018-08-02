namespace RingCentral
{
    public partial class CustomCompanyGreetingRequest
    {
        // Type of a greeting
        public string @type { get; set; }
        // Information on an answering rule that the greeting is applied to
        public CustomCompanyGreetingAnsweringRuleInfo @answeringRule { get; set; }
        // Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording'
        public CustomCompanyGreetingLanguageInfoRequest @language { get; set; }
    }
}
