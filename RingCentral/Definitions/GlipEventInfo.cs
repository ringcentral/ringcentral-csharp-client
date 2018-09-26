namespace RingCentral
{
    public partial class GlipEventInfo
    {
        // Internal identifier of an event
        public string @id { get; set; }
        // Internal identifier of a person created an event
        public string @creatorId { get; set; }
        // Event title
        public string @title { get; set; }
        // Datetime of starting an event
        public string @startTime { get; set; }
        // Datetime of ending an event
        public string @endTime { get; set; }
        // Indicates whether an event has some specific time slot or lasts for the whole day(s)
        public bool? @allDay { get; set; }
        // Event recurrence settings.
        public string @recurrence { get; set; }
        // Condition of ending
        public string @endingCondition { get; set; }
        // Count of iterations. For periodic events only
        public long? @endingAfter { get; set; }
        // Iterations end datetime for periodic events
        public string @endingOn { get; set; }
        // Hex color code, specifying font color of Event title (including its presentation in Calendar)
        public string @color { get; set; }
        // Event location
        public string @location { get; set; }
        // Event details
        public string @description { get; set; }
    }
}
