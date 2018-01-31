namespace RingCentral
{
    public partial class MeetingInfo
    {
        // Canonical URI of a meeting resource
        public string @uri { get; set; }
        // Internal identifier of a meeting as retrieved from Zoom
        public string @id { get; set; }
        // Topic of a meeting
        public string @topic { get; set; }
        // Type of a meeting
        public string @meetingType { get; set; }
        // Password required to join a meeting
        public string @password { get; set; }
        // Current status of a meeting
        public string @status { get; set; }
        // Links to start/join the meeting
        public LinksInfo @links { get; set; }
        // Schedule of a meeting
        public MeetingScheduleInfo @schedule { get; set; }
        // If 'True' then the meeting can be joined and started by any participant (not host only). Supported for the meetings of 'Scheduled' and 'Recurring' type.
        public bool? @allowJoinBeforeHost { get; set; }
        // Enables starting video when host joins the meeting
        public bool? @startHostVideo { get; set; }
        // Enables starting video when participants join the meeting
        public bool? @startParticipantsVideo { get; set; }
        // Meeting audio options. Possible values are 'Phone', 'ComputerAudio'
        public string[] @audioOptions { get; set; }
    }
}
