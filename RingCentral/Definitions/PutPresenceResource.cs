namespace RingCentral
{
    public partial class PutPresenceResource
    {
        //
        public string @userStatus { get; set; }
        //
        public string @message { get; set; }
        //
        public string @dndStatus { get; set; }
        //
        public bool? @allowSeeMyPresence { get; set; }
        //
        public bool? @ringOnMonitoredCall { get; set; }
        //
        public bool? @pickUpCallsOnHold { get; set; }
    }
}
