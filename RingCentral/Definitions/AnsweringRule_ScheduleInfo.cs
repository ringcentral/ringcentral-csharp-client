namespace RingCentral
{
    public partial class AnsweringRule_ScheduleInfo
    {
        // Weekly schedule. If specified, ranges cannot be specified
        public WeeklyScheduleInfo @weeklyRanges { get; set; }
        // Specific data ranges. If specified, weeklyRanges cannot be specified
        public RangesInfo @ranges { get; set; }
    }
}
