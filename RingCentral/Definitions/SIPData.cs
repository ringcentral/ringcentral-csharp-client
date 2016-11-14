namespace RingCentral
{
    public partial class SIPData
    {
        // Recipient data
        public string @toTag { get; set; }
        // Sender data
        public string @fromTag { get; set; }
        // Remote address URL
        public string @remoteUri { get; set; }
        // Local address URL
        public string @localUri { get; set; }
    }
}
