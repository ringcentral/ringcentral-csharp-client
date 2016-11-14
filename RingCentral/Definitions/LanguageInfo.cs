namespace RingCentral
{
    public partial class LanguageInfo
    {
        // Internal identifier of a language
        public string @id { get; set; }
        // Canonical URI of a language
        public string @uri { get; set; }
        // Indicates whether a language is available as greeting language
        public bool? @greeting { get; set; }
        // Indicates whether a language is available as formatting locale
        public bool? @formattingLocale { get; set; }
        // Localization code of a language
        public string @localeCode { get; set; }
        // Official name of a language
        public string @name { get; set; }
        // Indicates whether a language is available as UI language
        public bool? @ui { get; set; }
    }
}
