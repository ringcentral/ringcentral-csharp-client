namespace RingCentral
{
    public partial class CompanyAnsweringRuleScheduleInfoRequest
    {
        // Weekly schedule. If specified, ranges cannot be specified
        public CompanyAnsweringRuleWeeklyScheduleInfoRequest @weeklyRanges { get; set; }
        // Specific data ranges. If specified, weeklyRanges cannot be specified
        public RangesInfo[] @ranges { get; set; }
        // Reference to Business Hours or After Hours schedule = ['BusinessHours', 'AfterHours']
        public string @ref { get; set; }
    }
}
