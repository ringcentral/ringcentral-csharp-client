namespace RingCentral
{
    public partial class MeetingRequestResource
    {
        //
        public string @topic { get; set; }
        //
        public string @meetingType { get; set; }
        //
        public MeetingScheduleResource @schedule { get; set; }
        //
        public string @password { get; set; }
        //
        public HostInfoRequest @host { get; set; }
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
