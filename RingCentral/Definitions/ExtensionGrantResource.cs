namespace RingCentral
{
    public partial class ExtensionGrantResource
    {
        //
        public string @uri { get; set; }
        //
        public InlinedExtensionResource @extension { get; set; }
        //
        public bool? @callPickup { get; set; }
        //
        public bool? @callMonitoring { get; set; }
    }
}
