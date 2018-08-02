namespace RingCentral
{
    public partial class ActiveCallsRecordExtensionInfo
    {
        // Link to an extension on whose behalf a call is initiated
        public string @uri { get; set; }
        // Internal identifier of an extension on whose behalf a call is initiated
        public string @id { get; set; }
    }
}
