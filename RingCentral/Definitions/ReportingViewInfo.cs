namespace RingCentral
{
    public partial class ReportingViewInfo
    {
        // User-defined name of a 'View'. The maximum value is 255
        public string @name { get; set; }
        // List of pages, the max amount is 10
        public ReportingPagesInfo[] @pages { get; set; }
        // List of schedules, the max amount is 5. Each 'View' may have several schedules for reporting. For example, customer may want to get daily and weekly reports with the same set of settings
        public ReportingSchedulesInfo[] @schedules { get; set; }
    }
}
