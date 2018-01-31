namespace RingCentral
{
    public partial class CompanyBusinessHours
    {
        // Canonical URI of a business-hours resource
        public string @uri { get; set; }
        // Schedule when an answering rule is applied
        public CompanyBusinessHoursScheduleInfo @schedule { get; set; }
    }
}
