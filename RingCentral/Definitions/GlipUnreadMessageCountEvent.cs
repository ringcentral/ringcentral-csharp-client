namespace RingCentral
{
    public partial class GlipUnreadMessageCountEvent
    {
        // Universally unique identifier of a notification
        public string @uuid { get; set; }
        // Apple notification data
        public GlipAPNSInfo @pn_apns { get; set; }
        // GCM data
        public GCMInfo @pn_gcm { get; set; }
    }
}
