namespace RingCentral
{
    public partial class CallStatusInfo
    {
        // Status code of a call
        public string @code { get; set; }
        // Peer session / party data. Valid in Gone state only
        public PeerInfo @peerId { get; set; }
        // Reason of call termination. For 'Disconnected' code only
        public string @reason { get; set; }
        // Optional message
        public string @description { get; set; }
    }
}
