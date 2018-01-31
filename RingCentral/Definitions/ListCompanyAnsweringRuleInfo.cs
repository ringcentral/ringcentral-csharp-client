namespace RingCentral
{
    public partial class ListCompanyAnsweringRuleInfo
    {
        // Internal identifier of an answering rule
        public string @id { get; set; }
        // Canonical URI of an answering rule
        public string @uri { get; set; }
        // Specifies if the rule is active or inactive. The default value is 'True'
        public bool? @enabled { get; set; }
        // Type of an answering rule, the default value is 'Custom' = ['BusinessHours', 'AfterHours', 'Custom']
        public string @type { get; set; }
        // Name of an answering rule specified by user. Max number of symbols is 30. The default value is 'My Rule N' where 'N' is the first free number
        public string @name { get; set; }
    }
}
