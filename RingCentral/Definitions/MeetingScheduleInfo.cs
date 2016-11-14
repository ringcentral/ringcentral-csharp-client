namespace RingCentral
{
    public partial class MeetingScheduleInfo
    {
        // Start time of a meeting in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @startTime { get; set; }
        // Duration of a meeting in minutes
        public long? @durationInMinutes { get; set; }
        // Timezone of a meeting
        public MeetingScheduleInfo_TimezoneInfo @timeZone { get; set; }
    }
}
