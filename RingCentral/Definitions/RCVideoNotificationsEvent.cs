namespace RingCentral
{
    public partial class RCVideoNotificationsEvent
    {
        // Identifier of a meeting
        public string @id { get; set; }
        // Meeting Name
        public string @name { get; set; }
        // Datetime of meeting start in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string @start { get; set; }
        // Meeting duration
        public long? @duration { get; set; }
        // Meeting participants information
        public RCVParticipantsInfo @participants { get; set; }
        // Specifies whether a meeting is recorded or not
        public bool? @recorded { get; set; }
        // Meeting recording information, if recorded value is 'True'
        public RCVRecordingInfo @recording { get; set; }
    }
}
