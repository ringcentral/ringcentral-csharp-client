namespace RingCentral
{
    public partial class GlipMessageAttachmentInfoRequest
    {
        // Type of attachment
        public string @type { get; set; }
        // Attachment title
        public string @title { get; set; }
        // Default message returned in case the client does not support interactive messages
        public string @fallback { get; set; }
        // Hex color code specifying font color of Event title, including its presentation in Calendar; or the color of the side border of an interactive message of a Card
        public string @color { get; set; }
        // Introductory text displayed directly above a message
        public string @intro { get; set; }
        // Information about the author
        public GlipMessageAttachmentAuthorInfo @author { get; set; }
        // Text of attachment (up to 1000 chars), supports GlipDown
        public string @text { get; set; }
        // Link to an image displayed at the bottom of a message
        public string @imageUri { get; set; }
        // Link to an image preview displayed to the right of a message (82x82)
        public string @thumbnailUri { get; set; }
        // Individual subsections within a message
        public GlipMessageAttachmentFieldsInfo[] @fields { get; set; }
        // Message footer information
        public GlipMessageAttachmentFootnoteInfo @footnote { get; set; }
        // Datetime of starting an event
        public string @startTime { get; set; }
        // Datetime of ending an event
        public string @endTime { get; set; }
        // Indicates whether an event has some specific time slot or lasts for the whole day(s)
        public bool? @allDay { get; set; }
        // Event recurrence settings. For non-periodic events the value is 'None'. Must be greater or equal to event duration: 1- Day/Weekday; 7 - Week; 28 - Month; 365 - Year
        public string @recurrence { get; set; }
        // Condition of ending
        public string @endingCondition { get; set; }
    }
}
