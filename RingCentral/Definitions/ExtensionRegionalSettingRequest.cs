namespace RingCentral
{
    public partial class ExtensionRegionalSettingRequest
    {
        //
        public ExtensionCountryInfoRequest @homeCountry { get; set; }
        //
        public ExtensionTimezoneInfoRequest @timezone { get; set; }
        //
        public ExtensionLanguageInfoRequest @language { get; set; }
        //
        public ExtensionGreetingLanguageInfoRequest @greetingLanguage { get; set; }
        //
        public ExtensionFormattingLocaleInfoRequest @formattingLocale { get; set; }
        // Time format setting. The default value is '12h' = ['12h', '24h']
        public string @timeFormat { get; set; }
    }
}
