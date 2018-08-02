namespace RingCentral
{
    public partial class CallRecordingExtensionResource
    {
        // Internal identifier of an extension
        public string @id { get; set; }
        //
        public string @uri { get; set; }
        //
        public string @extensionNumber { get; set; }
        //
        public string @type { get; set; }
        // Direction of call
        public string @callDirection { get; set; }
    }
}
