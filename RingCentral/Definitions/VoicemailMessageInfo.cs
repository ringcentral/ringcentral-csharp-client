namespace RingCentral
{
    public partial class VoicemailMessageInfo
    {
        // Internal identifier of a voicemail message
        public string @id { get; set; }
        // Type of a message - 'Voicemail'
        public string @type { get; set; }
        // Link to a voicemail message resource
        public string @uri { get; set; }
    }
}
