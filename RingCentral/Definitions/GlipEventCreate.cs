namespace RingCentral
{
    public partial class GlipEventCreate
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
        // Indicates whether event has some specific time slot or lasts for whole day(s)
        public bool? @allDay { get; set; }
        // Event recurrence settings. For non-periodic events the value is 'None'. Must be greater or equal to event duration: 1- Day/Weekday; 7 - Week; 28 - Month; 365 - Year
        public string @recurrence { get; set; }
        // Condition of ending
        public string @endingCondition { get; set; }
        // Count of iterations. For periodic events only. Value range is 1 - 10. Must be specified if 'endingCondition' is 'Count'
        public long? @endingAfter { get; set; }
        // Iterations end datetime for periodic events.
        public string @endingOn { get; set; }
        // Hex color code, specifying font color of Event title (including its presentation in Calendar)
        public string @color { get; set; }
        // Event location
        public string @location { get; set; }
        // Event details
        public string @description { get; set; }
    }
}
