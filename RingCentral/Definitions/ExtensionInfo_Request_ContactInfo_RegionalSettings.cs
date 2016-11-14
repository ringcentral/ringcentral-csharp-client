namespace RingCentral
{
    public partial class ExtensionInfo_Request_ContactInfo_RegionalSettings
    {
        // Timezone data
        public ExtensionInfo_Request_ContactInfo_RegionalSettings_Timezone @timezone { get; set; }
        // User interface language data
        public ExtensionInfo_Request_ContactInfo_RegionalSettings_Language @language { get; set; }
        // Information on language used for telephony greetings
        public ExtensionInfo_Request_ContactInfo_RegionalSettings_GreetingLanguage @greetingLanguage { get; set; }
        // Formatting language preferences for numbers, dates and currencies
        public ExtensionInfo_Request_ContactInfo_RegionalSettings_FormattingLocale @formattingLocale { get; set; }
    }
}
