namespace RingCentral
{
    public partial class AcceptableLanguageTag
    {
        //
        public string @tag { get; set; }
        //
        public string @primaryTag { get; set; }
        //
        public string @subTags { get; set; }
        //
        public long? @quality { get; set; }
        //
        public Locale @asLocale { get; set; }
    }
}
