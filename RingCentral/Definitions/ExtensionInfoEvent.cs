namespace RingCentral
{
    public partial class ExtensionInfoEvent
    {
        // Internal identifier of an extension
        public string @extensionId { get; set; }
        // Type of extension info change
        public string @eventType { get; set; }
    }
}
