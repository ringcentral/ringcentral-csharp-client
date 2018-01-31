namespace RingCentral
{
    public partial class MeetingResponseResource
    {
        //
        public string @uri { get; set; }
        //
        public string @uuid { get; set; }
        //
        public string @id { get; set; }
        //
        public string @topic { get; set; }
        //
        public string @meetingType { get; set; }
        //
        public string @password { get; set; }
        //
        public string @status { get; set; }
        //
        public MeetingLinks @links { get; set; }
        //
        public MeetingScheduleResource @schedule { get; set; }
        //
        public bool? @allowJoinBeforeHost { get; set; }
        //
        public bool? @startHostVideo { get; set; }
        //
        public bool? @startParticipantsVideo { get; set; }
        //
        public string[] @audioOptions { get; set; }
    }
}
