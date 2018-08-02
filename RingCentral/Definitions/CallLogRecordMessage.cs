namespace RingCentral
{
    public partial class CallLogRecordMessage
    {
        // Internal identifier of a message
        public string @id { get; set; }
        // Type of a message
        public string @type { get; set; }
        // Link to a message resource
        public string @uri { get; set; }
    }
}
