namespace RingCentral
{
    public partial class CallSessionObject
    {
        // Internal identifier of a call session
        public string @id { get; set; }
        // Initial data of a call session
        public OriginInfo @origin { get; set; }
        // For calls of 'Conference' type only
        public string @voiceCallToken { get; set; }
        // Information on a party of a call session
        public CallParty @parties { get; set; }
        // Date and time of the latest session update represented in Unix time format
        public string @creationTime { get; set; }
    }
}
