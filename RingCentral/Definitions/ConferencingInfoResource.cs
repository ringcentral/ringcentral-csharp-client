namespace RingCentral
{
    public partial class ConferencingInfoResource
    {
        //
        public string @uri { get; set; }
        //
        public string @phoneNumber { get; set; }
        //
        public string @hostCode { get; set; }
        //
        public string @participantCode { get; set; }
        //
        public bool? @allowJoinBeforeHost { get; set; }
        //
        public string @tapToJoinUri { get; set; }
        //
        public string @supportUri { get; set; }
        //
        public string @mode { get; set; }
        //
        public ConferencingNumberResource[] @phoneNumbers { get; set; }
    }
}
