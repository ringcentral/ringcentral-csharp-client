namespace RingCentral
{
    public partial class PromptLanguageInfo
    {
        // Link to a prompt language
        public string @uri { get; set; }
        // Internal identifier of a language
        public string @id { get; set; }
        // Language name
        public string @name { get; set; }
        // Language locale code
        public string @localeCode { get; set; }
    }
}
