namespace RingCentral
{
    public partial class MeetingScheduleResource
    {
        //
        public string @startTime { get; set; }
        //
        public long? @durationInMinutes { get; set; }
        //
        public TimezoneResource @timeZone { get; set; }
    }
}
