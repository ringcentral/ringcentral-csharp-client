namespace RingCentral
{
    public partial class NotificationInfo
    {
        // Alert information
        public AlertInfo @alert { get; set; }
        // Number of incoming messages
        public string @badge { get; set; }
        // Message sound
        public string @sound { get; set; }
        // Content availability
        //public string @content-available { get; set; }
        // Category of a message
        public string @category { get; set; }
    }
}
