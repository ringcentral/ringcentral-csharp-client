namespace RingCentral
{
    public partial class ExtensionFavoritesEventBody
    {
        // Internal identifier of an extension
        public string @extensionId { get; set; }
        // Internal identifier of a subscription owner extension
        public string @ownerId { get; set; }
    }
}
