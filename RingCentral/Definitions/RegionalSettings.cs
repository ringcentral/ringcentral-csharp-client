namespace RingCentral
{
    public partial class RegionalSettings
    {
        // Extension country information
        public CountryInfo @homeCountry { get; set; }
        // Extension timezone information
        public TimezoneInfo @timezone { get; set; }
        // User interface language data
        public LanguageInfo @language { get; set; }
        // Information on language used for telephony greetings
        public GreetingLanguageInfo @greetingLanguage { get; set; }
        // Formatting language preferences for numbers, dates and currencies
        public FormattingLocaleInfo @formattingLocale { get; set; }
    }
}
