namespace RingCentral
{
    public partial class CallerBlockingSettingsUpdate
    {
        // Call blocking options: either specific or all calls and faxes
        public string @mode { get; set; }
        // Determines how to handle calls with no caller ID in 'Specific' mode
        public string @noCallerId { get; set; }
        // Blocking settings for pay phones
        public string @payPhones { get; set; }
        // List of greetings played for blocked callers
        public BlockedCallerGreetingInfo[] @greetings { get; set; }
    }
}
