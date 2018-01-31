namespace RingCentral
{
    public partial class RingOutStatusInfo
    {
        // Status of a call
        public string @callStatus { get; set; }
        // Status of a calling party
        public string @callerStatus { get; set; }
        // Status of a called party
        public string @calleeStatus { get; set; }
    }
}
