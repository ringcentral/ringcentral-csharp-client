namespace RingCentral
{
    public partial class CallQueueInfo
    {
        // Link to a call queue
        public string @uri { get; set; }
        // Internal identifier of a call queue
        public string @id { get; set; }
        // Extension number of a call queue
        public string @extensionNumber { get; set; }
        // Name of a call queue
        public string @name { get; set; }
    }
}
