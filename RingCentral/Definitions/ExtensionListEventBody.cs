namespace RingCentral
{
    public partial class ExtensionListEventBody
    {
        // Internal identifier of an extension
        public string @extensionId { get; set; }
        // Type of extension info change
        public string @eventType { get; set; }
        // Internal identifier of a subscription owner extension
        public string @ownerId { get; set; }
    }
}
