namespace RingCentral
{
    public partial class NotificationInfo
    {
        // Alert information
        public AlertInfo @alerts { get; set; }
        // Number of incoming messages
        public string @badge { get; set; }
        // Message sound
        public string @sound { get; set; }
        // Content availability
        public string @contentAvailable { get; set; }
        // Category of a message
        public string @category { get; set; }
    }
}
