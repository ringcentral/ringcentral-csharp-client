namespace RingCentral
{
    public partial class CallQueueMemberInfo
    {
        // Link to a call queue member
        public string @uri { get; set; }
        // Internal identifier of a call queue member
        public string @id { get; set; }
        // Extension number of a call queue member
        public string @extensionNumber { get; set; }
    }
}
