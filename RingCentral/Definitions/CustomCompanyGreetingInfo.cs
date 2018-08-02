namespace RingCentral
{
    public partial class CustomCompanyGreetingInfo
    {
        // Link to an extension custom greeting
        public string @uri { get; set; }
        // Internal identifier of an answering rule
        public string @id { get; set; }
        // Type of a company greeting
        public string @type { get; set; }
        // Content media type in WAV/MP3 format
        public string @contentType { get; set; }
        // Link to a greeting content (audio file)
        public string @contentUri { get; set; }
        // Information on an answering rule that the greeting is applied to
        public CustomGreetingAnsweringRuleInfo @answeringRule { get; set; }
        // Information on a greeting language. Supported for types 'StopRecording', 'StartRecording', 'AutomaticRecording'
        public CustomCompanyGreetingLanguageInfo @language { get; set; }
    }
}
