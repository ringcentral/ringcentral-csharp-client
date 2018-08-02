namespace RingCentral
{
    public partial class DisabledFilterInfo
    {
        // Event filter that is disabled for the user
        public string @filter { get; set; }
        // Reason why the filter is disabled for the user
        public string @reason { get; set; }
        // Error message
        public string @message { get; set; }
    }
}
