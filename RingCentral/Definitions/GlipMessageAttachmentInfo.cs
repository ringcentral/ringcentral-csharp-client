namespace RingCentral
{
    public partial class GlipMessageAttachmentInfo
    {
        // Internal identifier of an attachment
        public string @id { get; set; }
        // Type of an attachment
        public string @type { get; set; }
        // A string of default text that will be rendered in the case that the client does not support Interactive Messages
        public string @fallback { get; set; }
        // A pretext to the message
        public string @intro { get; set; }
        // Information about the author
        public GlipMessageAttachmentAuthorInfo @author { get; set; }
        // Message title
        public string @title { get; set; }
        // A large string field (up to 1000 chars) to be displayed as the body of a message (Supports GlipDown)
        public string @text { get; set; }
        // url used to display a single image at the bottom of a message
        public string @imageUri { get; set; }
        // url used to display a thumbnail to the right of a message (82x82)
        public string @thumbnailUri { get; set; }
        // Information on navigation
        public GlipMessageAttachmentFieldsInfo[] @fields { get; set; }
        // Message Footer
        public GlipMessageAttachmentFootnoteInfo @footnote { get; set; }
        // Internal identifier of a person created an event
        public string @creatorId { get; set; }
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
        // Hex color code specifying font color of Event title, including its presentation in Calendar; or the color of the side border of an interactive message of a Card
        public string @color { get; set; }
        // Event location
        public string @location { get; set; }
        // Event details
        public string @description { get; set; }
    }
}
