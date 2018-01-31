namespace RingCentral
{
    public partial class RegionalSettingsResource
    {
        //
        public TimezoneResource @timezone { get; set; }
        //
        public CountryResource @homeCountry { get; set; }
        //
        public LanguageResource @language { get; set; }
        //
        public LanguageResource @greetingLanguage { get; set; }
        //
        public LanguageResource @formattingLocale { get; set; }
    }
}
