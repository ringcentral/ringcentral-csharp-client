namespace RingCentral
{
    public partial class AutomaticRecordingResource
    {
        // Flag for controling Automatic Call Recording settings
        public bool? @enabled { get; set; }
        // Flag for controlling 'Play Call Recording Announcement for Outbound Calls' settings
        public bool? @outboundCallTones { get; set; }
        // Flag for controlling 'Play periodic tones for outbound calls' settings
        public bool? @outboundCallAnnouncement { get; set; }
        // Flag for controlling 'Allow mute in auto call recording' settings
        public bool? @allowMute { get; set; }
        // Total amount of extension that are used in call recordings
        public long? @extensionCount { get; set; }
    }
}
