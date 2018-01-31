namespace RingCentral
{
    public partial class ScheduleInfo
    {
        // Weekly schedule
        public WeeklyScheduleInfo @weeklyRanges { get; set; }
        // Specific data ranges
        public RangesInfo @ranges { get; set; }
        // The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method
        public string @ref { get; set; }
    }
}
