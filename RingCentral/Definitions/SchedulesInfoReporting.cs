namespace RingCentral
{
    public partial class SchedulesInfoReporting
    {
        // Unique schedule identifier
        public string @scheduleId { get; set; }
        // Recurrence pattern of a schedule
        public RecurrenceInfoReporting[] @recurrence { get; set; }
        // Type of report. Detailed reports include tables with data. Simple reports only include charts
        public string @viewType { get; set; }
        // Set of optional attachments. Basically, every report email is in HTML format. Optionally, it can contain PDF or CSV files
        public AttachmentInfoReporting[] @attachments { get; set; }
        // List of pages to include to the report. If empty, all pages are included. Otherwise, only specified pages are included. API doesn't check validity of page names. Client application is responsible to do that
        public string[] @pages { get; set; }
        // List of emails to which to send rendered reports
        public string[] @recipients { get; set; }
    }
}
