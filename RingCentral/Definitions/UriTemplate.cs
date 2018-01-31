namespace RingCentral
{
    public partial class UriTemplate
    {
        //
        public string @template { get; set; }
        //
        public PatternWithGroups @pattern { get; set; }
        //
        public string[] @templateVariables { get; set; }
        //
        public long? @numberOfExplicitRegexes { get; set; }
        //
        public long? @numberOfRegexGroups { get; set; }
        //
        public long? @numberOfExplicitCharacters { get; set; }
        //
        public long? @numberOfTemplateVariables { get; set; }
    }
}
