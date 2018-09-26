namespace RingCentral
{
    public partial class UserBusinessHoursUpdateResponse
    {
        // Canonical URI of a business-hours resource
        public string @uri { get; set; }
        // Schedule when an answering rule is applied
        public UserBusinessHoursScheduleInfo @schedule { get; set; }
    }
}
