namespace RingCentral
{
    public partial class GetUserBusinessHoursResponse
    {
        // Canonical URI of a business-hours resource
        public string @uri { get; set; }
        // Schedule when an answering rule is applied
        public ScheduleInfoUserBusinessHours @schedule { get; set; }
    }
}
