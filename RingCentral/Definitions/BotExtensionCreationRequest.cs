namespace RingCentral
{
    public partial class BotExtensionCreationRequest
    {
        // Bot name (equals to extension first name)
        public string @name { get; set; }
        // Key of a bot application
        public string @applicationKey { get; set; }
        // User extension identifier
        public string @creatorId { get; set; }
    }
}
