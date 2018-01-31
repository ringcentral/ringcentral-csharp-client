namespace RingCentral
{
    public partial class SetReportingSettingsRequest
    {
        // List of 'View' structures with a tuple of filter values, pages and schedules
        public ViewInfoReporting[] @views { get; set; }
    }
}
